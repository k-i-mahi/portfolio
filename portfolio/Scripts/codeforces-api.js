/**
 * Codeforces API Integration
 * Fetches live data from Codeforces API for user: being_mysterious
 */

class CodeforcesAPI {
    constructor(handle = 'being_mysterious') {
        this.handle = handle;
        this.baseURL = 'https://codeforces.com/api';
        this.cache = {};
        this.cacheTimeout = 5 * 60 * 1000; // 5 minutes cache
    }

    /**
     * Fetch user information from Codeforces API
     */
    async getUserInfo() {
        const cacheKey = `user_${this.handle}`;
        
        // Check cache first
        if (this.cache[cacheKey] && (Date.now() - this.cache[cacheKey].timestamp < this.cacheTimeout)) {
            return this.cache[cacheKey].data;
        }

        try {
            // Note: Due to CORS policies, this might need a proxy service in production
            const response = await fetch(`${this.baseURL}/user.info?handles=${this.handle}`);
            
            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }
            
            const data = await response.json();
            
            if (data.status === 'OK' && data.result && data.result.length > 0) {
                const userData = data.result[0];
                
                // Cache the result
                this.cache[cacheKey] = {
                    data: userData,
                    timestamp: Date.now()
                };
                
                return userData;
            } else {
                throw new Error('Invalid API response');
            }
        } catch (error) {
            console.warn('Codeforces API Error:', error.message);
            
            // Return fallback data if API fails
            return this.getFallbackData();
        }
    }

    /**
     * Get user submission statistics
     */
    async getUserStatus() {
        try {
            const response = await fetch(`${this.baseURL}/user.status?handle=${this.handle}&from=1&count=5000`);
            const data = await response.json();
            
            if (data.status === 'OK') {
                return this.analyzeSubmissions(data.result);
            }
        } catch (error) {
            console.warn('Failed to fetch user submissions:', error.message);
        }
        
        return {
            solvedProblems: 400,
            totalSubmissions: 800,
            acceptedSubmissions: 450,
            solvedByRating: {
                '800-1000': 150,
                '1001-1200': 120,
                '1201-1400': 80,
                '1401-1600': 40,
                '1601+': 10
            }
        };
    }

    /**
     * Analyze submission data to get meaningful statistics
     */
    analyzeSubmissions(submissions) {
        const solved = new Set();
        const solvedByRating = {};
        let acceptedSubmissions = 0;

        submissions.forEach(submission => {
            if (submission.verdict === 'OK') {
                const problemKey = `${submission.problem.contestId}-${submission.problem.index}`;
                solved.add(problemKey);
                acceptedSubmissions++;
                
                const rating = submission.problem.rating || 0;
                const ratingRange = this.getRatingRange(rating);
                solvedByRating[ratingRange] = (solvedByRating[ratingRange] || 0) + 1;
            }
        });

        return {
            solvedProblems: solved.size,
            totalSubmissions: submissions.length,
            acceptedSubmissions,
            solvedByRating
        };
    }

    /**
     * Get rating range for categorization
     */
    getRatingRange(rating) {
        if (rating <= 1000) return '800-1000';
        if (rating <= 1200) return '1001-1200';
        if (rating <= 1400) return '1201-1400';
        if (rating <= 1600) return '1401-1600';
        return '1601+';
    }

    /**
     * Fallback data when API is unavailable
     */
    getFallbackData() {
        return {
            handle: this.handle,
            firstName: '',
            lastName: '',
            maxRating: 1456,
            maxRank: 'specialist',
            rating: 1400,
            rank: 'specialist',
            contribution: 0
        };
    }

    /**
     * Update portfolio with live data
     */
    async updatePortfolioStats() {
        try {
            console.log('?? Fetching Codeforces data...');
            
            const userInfo = await this.getUserInfo();
            const userStats = await this.getUserStatus();
            
            // Update hero section stats
            this.updateHeroStats(userInfo, userStats);
            
            // Update competitive programming section
            this.updateCompetitiveProgramming(userInfo, userStats);
            
            console.log('? Portfolio updated with live Codeforces data!', {
                handle: userInfo.handle,
                maxRating: userInfo.maxRating,
                solvedProblems: userStats.solvedProblems
            });
            
        } catch (error) {
            console.error('? Failed to update portfolio with live data:', error);
        }
    }

    /**
     * Update hero section counters
     */
    updateHeroStats(userInfo, userStats) {
        // Update problems solved counter
        const problemsCounter = document.querySelector('.stats-counter[data-target="800"]');
        if (problemsCounter) {
            problemsCounter.setAttribute('data-target', userStats.solvedProblems);
            problemsCounter.textContent = userStats.solvedProblems;
        }

        // Update max rating counter
        const ratingCounter = document.querySelector('.stats-counter[data-target="1456"]');
        if (ratingCounter) {
            ratingCounter.setAttribute('data-target', userInfo.maxRating);
            ratingCounter.textContent = userInfo.maxRating;
        }
    }

    /**
     * Update competitive programming section
     */
    updateCompetitiveProgramming(userInfo, userStats) {
        // Find Codeforces card and update stats
        const cfCard = document.querySelector('.platform-card .platform-username');
        if (cfCard && cfCard.textContent.includes('being_mysterious')) {
            const card = cfCard.closest('.platform-card');
            
            // Update rating
            const ratingSpan = card.querySelector('.stat-item .stats-counter');
            if (ratingSpan && ratingSpan.textContent === '1456') {
                ratingSpan.textContent = userInfo.maxRating;
            }
            
            // Update problems solved
            const problemsSpan = card.querySelectorAll('.stat-item .stats-counter')[1];
            if (problemsSpan) {
                problemsSpan.textContent = userStats.solvedProblems + '+';
            }
            
            // Update rank
            const rankSpan = card.querySelectorAll('.stat-item .stats-counter')[3];
            if (rankSpan) {
                rankSpan.textContent = userInfo.maxRank;
            }
        }
    }
}

// Initialize and use the API
const cfAPI = new CodeforcesAPI('being_mysterious');

// Auto-update when page loads
document.addEventListener('DOMContentLoaded', () => {
    // Add a small delay to ensure other scripts have loaded
    setTimeout(() => {
        cfAPI.updatePortfolioStats();
    }, 2000);
});

// Refresh data every 10 minutes
setInterval(() => {
    cfAPI.updatePortfolioStats();
}, 10 * 60 * 1000);

// Export for manual usage
window.CodeforcesAPI = CodeforcesAPI;
window.cfAPI = cfAPI;

console.log('?? Codeforces API integration loaded! Handle: being_mysterious');
console.log('?? Data will be fetched automatically. Manual refresh: cfAPI.updatePortfolioStats()');