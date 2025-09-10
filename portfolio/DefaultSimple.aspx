<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultSimple.aspx.cs" Inherits="Portfolio.DefaultSimple" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="Mahir Rahman - Competitive Programmer, Software Developer & Tech Enthusiast from KUET. Specializing in algorithms, hardware projects, and full-stack development." />
    <meta name="keywords" content="Mahir Rahman, KUET, competitive programming, software developer, Codeforces, Kaggle, hardware projects, robotics, chess, photography, ASP.NET, algorithms" />
    <meta name="author" content="Mahir Rahman" />
    <meta property="og:title" content="Mahir Rahman - Competitive Programmer & Tech Enthusiast" />
    <meta property="og:description" content="CSE Student at KUET | 500+ Problems Solved | Hardware Projects | Kaggle Competitor" />
    <meta property="og:type" content="website" />
    <title>Mahir Rahman - Competitive Programmer & Tech Enthusiast | KUET CSE</title>
    
    <!-- External Resources -->
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&family=JetBrains+Mono:wght@100;200;300;400;500;600;700;800&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" />
    <link href="Styles/portfolio.css" rel="stylesheet" />
    
    <!-- Dynamic Theme and Enhanced Animations -->
    <style>
        :root {
            /* Light Theme */
            --primary-color: #1e293b;
            --secondary-color: #3b82f6;
            --accent-color: #ef4444;
            --success-color: #10b981;
            --warning-color: #f59e0b;
            --info-color: #06b6d4;
            --text-color: #1f2937;
            --text-light: #6b7280;
            --text-muted: #9ca3af;
            --bg-color: #f8fafc;
            --bg-secondary: #f1f5f9;
            --white: #ffffff;
            --border-color: #e2e8f0;
            --shadow-light: 0 4px 6px -1px rgba(0, 0, 0, 0.1);
            --shadow: 0 10px 25px -3px rgba(0, 0, 0, 0.1);
            --shadow-hover: 0 20px 40px -4px rgba(0, 0, 0, 0.15);
            --shadow-intense: 0 25px 50px -12px rgba(0, 0, 0, 0.25);
            --gradient-primary: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            --gradient-secondary: linear-gradient(135deg, #f093fb 0%, #f5576c 100%);
            --gradient-success: linear-gradient(135deg, #84fab0 0%, #8fd3f4 100%);
            --gradient-warning: linear-gradient(135deg, #ffecd2 0%, #fcb69f 100%);
            --gradient-hero: linear-gradient(135deg, #667eea 0%, #764ba2 50%, #f093fb 100%);
            --border-radius: 16px;
            --border-radius-sm: 8px;
            --border-radius-lg: 24px;
            --transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
            --transition-slow: all 0.5s cubic-bezier(0.4, 0, 0.2, 1);
            --font-primary: 'Poppins', sans-serif;
            --font-mono: 'JetBrains Mono', monospace;
        }

        [data-theme="dark"] {
            /* Dark Theme */
            --primary-color: #0f172a;
            --secondary-color: #60a5fa;
            --accent-color: #f87171;
            --success-color: #34d399;
            --warning-color: #fbbf24;
            --info-color: #22d3ee;
            --text-color: #f1f5f9;
            --text-light: #cbd5e1;
            --text-muted: #94a3b8;
            --bg-color: #020617;
            --bg-secondary: #0f172a;
            --white: #1e293b;
            --border-color: #334155;
            --shadow-light: 0 4px 6px -1px rgba(0, 0, 0, 0.3);
            --shadow: 0 10px 25px -3px rgba(0, 0, 0, 0.4);
            --shadow-hover: 0 20px 40px -4px rgba(0, 0, 0, 0.5);
            --shadow-intense: 0 25px 50px -12px rgba(0, 0, 0, 0.6);
            --gradient-primary: linear-gradient(135deg, #4c1d95 0%, #7c2d12 100%);
            --gradient-secondary: linear-gradient(135deg, #be123c 0%, #7c2d12 100%);
            --gradient-success: linear-gradient(135deg, #065f46 0%, #0c4a6e 100%);
            --gradient-warning: linear-gradient(135deg, #92400e 0%, #7c2d12 100%);
            --gradient-hero: linear-gradient(135deg, #4c1d95 0%, #7c2d12 50%, #be123c 100%);
        }

        /* Enhanced Base Styles */
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        html {
            scroll-behavior: smooth;
            overflow-x: hidden;
        }

        body {
            font-family: var(--font-primary);
            line-height: 1.7;
            color: var(--text-color);
            background-color: var(--bg-color);
            font-size: 16px;
            overflow-x: hidden;
            transition: var(--transition);
            -webkit-font-smoothing: antialiased;
            -moz-osx-font-smoothing: grayscale;
        }

        /* Enhanced Theme Toggle */
        .theme-toggle {
            position: fixed;
            top: 90px;
            right: 20px;
            z-index: 1001;
            background: var(--gradient-primary);
            color: white;
            border: none;
            border-radius: 50%;
            width: 56px;
            height: 56px;
            cursor: pointer;
            transition: var(--transition);
            box-shadow: var(--shadow);
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 1.4rem;
            backdrop-filter: blur(10px);
        }

        .theme-toggle:hover {
            transform: scale(1.1) rotate(180deg);
            box-shadow: var(--shadow-hover);
        }

        .theme-toggle:active {
            transform: scale(0.95);
        }

        /* Floating Action Menu */
        .floating-menu {
            position: fixed;
            bottom: 30px;
            right: 30px;
            z-index: 1000;
            display: flex;
            flex-direction: column;
            gap: 15px;
        }

        .floating-btn {
            width: 50px;
            height: 50px;
            border-radius: 50%;
            background: var(--gradient-primary);
            color: white;
            border: none;
            cursor: pointer;
            transition: var(--transition);
            box-shadow: var(--shadow);
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 1.2rem;
            text-decoration: none;
        }

        .floating-btn:hover {
            transform: translateY(-5px) scale(1.1);
            box-shadow: var(--shadow-hover);
        }

        /* Enhanced Typography */
        h1, h2, h3, h4, h5, h6 {
            font-family: var(--font-primary);
            font-weight: 600;
            line-height: 1.2;
            margin-bottom: 1rem;
            color: var(--text-color);
        }

        h1 { font-size: clamp(2.5rem, 5vw, 4rem); font-weight: 800; }
        h2 { font-size: clamp(2rem, 4vw, 3rem); font-weight: 700; }
        h3 { font-size: clamp(1.5rem, 3vw, 2.2rem); font-weight: 600; }
        h4 { font-size: clamp(1.2rem, 2.5vw, 1.8rem); }

        .text-gradient {
            background: var(--gradient-primary);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
        }

        /* Enhanced Container */
        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 0 20px;
            position: relative;
        }

        @media (min-width: 768px) {
            .container {
                padding: 0 40px;
            }
        }

        /* Enhanced Navigation */
        .header {
            position: fixed;
            top: 0;
            left: 0;
            right: 0;
            z-index: 999;
            background: rgba(255, 255, 255, 0.8);
            backdrop-filter: blur(20px);
            border-bottom: 1px solid var(--border-color);
            transition: var(--transition);
        }

        [data-theme="dark"] .header {
            background: rgba(15, 23, 42, 0.8);
        }

        .header.scrolled {
            background: rgba(255, 255, 255, 0.95);
            box-shadow: var(--shadow);
        }

        [data-theme="dark"] .header.scrolled {
            background: rgba(15, 23, 42, 0.95);
        }

        .nav {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 1rem 0;
            min-height: 70px;
        }

        .logo {
            font-size: 1.5rem;
            font-weight: 800;
            background: var(--gradient-primary);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            display: flex;
            align-items: center;
            gap: 0.5rem;
            text-decoration: none;
        }

        .nav-links {
            display: flex;
            list-style: none;
            gap: 2rem;
            align-items: center;
        }

        .nav-links a {
            color: var(--text-color);
            text-decoration: none;
            padding: 0.5rem 1rem;
            border-radius: var(--border-radius-sm);
            transition: var(--transition);
            font-weight: 500;
            position: relative;
            font-size: 0.9rem;
        }

        .nav-links a::before {
            content: '';
            position: absolute;
            bottom: -2px;
            left: 50%;
            width: 0;
            height: 2px;
            background: var(--gradient-primary);
            transition: var(--transition);
            transform: translateX(-50%);
        }

        .nav-links a:hover::before,
        .nav-links a.active::before {
            width: 80%;
        }

        .nav-links a:hover,
        .nav-links a.active {
            color: var(--secondary-color);
            transform: translateY(-2px);
        }

        .nav-links a.active {
            background: rgba(59, 130, 246, 0.1);
        }

        /* Mobile Navigation */
        .nav-toggle {
            display: none;
            flex-direction: column;
            cursor: pointer;
            padding: 0.5rem;
            gap: 4px;
        }

        .nav-toggle span {
            width: 25px;
            height: 3px;
            background: var(--text-color);
            border-radius: 2px;
            transition: var(--transition);
        }

        .nav-toggle.active span:nth-child(1) {
            transform: rotate(45deg) translate(5px, 5px);
        }

        .nav-toggle.active span:nth-child(2) {
            opacity: 0;
        }

        .nav-toggle.active span:nth-child(3) {
            transform: rotate(-45deg) translate(7px, -6px);
        }

        /* Enhanced Hero Section */
        .hero {
            background: var(--gradient-hero);
            color: white;
            padding: 120px 0 80px;
            text-align: center;
            position: relative;
            overflow: hidden;
            min-height: 100vh;
            display: flex;
            align-items: center;
        }

        .hero::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background: 
                radial-gradient(circle at 20% 80%, rgba(120, 119, 198, 0.3) 0%, transparent 50%),
                radial-gradient(circle at 80% 20%, rgba(255, 119, 198, 0.3) 0%, transparent 50%),
                radial-gradient(circle at 40% 40%, rgba(120, 219, 255, 0.2) 0%, transparent 50%);
        }

        .hero-content {
            position: relative;
            z-index: 2;
            max-width: 800px;
            margin: 0 auto;
        }

        .hero h1 {
            color: white;
            margin-bottom: 1.5rem;
            text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.3);
        }

        .hero-subtitle {
            font-size: clamp(1.2rem, 2.5vw, 2rem);
            margin-bottom: 1.5rem;
            opacity: 0.9;
            font-weight: 400;
            color: white;
            font-family: var(--font-mono);
        }

        .hero-description {
            font-size: clamp(1rem, 1.8vw, 1.3rem);
            margin-bottom: 3rem;
            opacity: 0.8;
            max-width: 600px;
            margin-left: auto;
            margin-right: auto;
            color: rgba(255, 255, 255, 0.9);
            line-height: 1.6;
        }

        /* Enhanced Stats */
        .hero-stats {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(180px, 1fr));
            gap: 2rem;
            margin: 3rem 0;
            max-width: 600px;
            margin-left: auto;
            margin-right: auto;
        }

        .stat-card {
            background: rgba(255, 255, 255, 0.1);
            backdrop-filter: blur(20px);
            padding: 2rem 1.5rem;
            border-radius: var(--border-radius);
            border: 1px solid rgba(255, 255, 255, 0.2);
            transition: var(--transition);
        }

        .stat-card:hover {
            transform: translateY(-5px) scale(1.05);
            background: rgba(255, 255, 255, 0.15);
        }

        .stats-counter {
            font-size: 2.5rem;
            font-weight: 800;
            color: white;
            display: block;
            font-family: var(--font-mono);
        }

        .stats-label {
            font-size: 0.9rem;
            color: rgba(255, 255, 255, 0.8);
            text-transform: uppercase;
            letter-spacing: 1px;
            font-weight: 500;
            margin-top: 0.5rem;
        }

        /* Enhanced CTA Button */
        .cta-button {
            display: inline-flex;
            align-items: center;
            gap: 0.5rem;
            background: rgba(255, 255, 255, 0.2);
            color: white;
            padding: 15px 35px;
            text-decoration: none;
            border-radius: 50px;
            transition: var(--transition);
            font-weight: 600;
            font-size: 1.1rem;
            margin-top: 2rem;
            border: 2px solid rgba(255, 255, 255, 0.3);
            backdrop-filter: blur(10px);
        }

        .cta-button:hover {
            transform: translateY(-3px) scale(1.05);
            background: rgba(255, 255, 255, 0.3);
            border-color: rgba(255, 255, 255, 0.5);
            box-shadow: var(--shadow-hover);
        }

        /* Enhanced Sections */
        .section {
            padding: 100px 0;
            position: relative;
        }

        .section:nth-child(even) {
            background: var(--bg-secondary);
        }

        .section-title {
            text-align: center;
            font-size: clamp(2.5rem, 4vw, 3.5rem);
            margin-bottom: 1rem;
            color: var(--text-color);
            position: relative;
            font-weight: 800;
        }

        .section-title .highlight {
            background: var(--gradient-primary);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
        }

        .section-subtitle {
            text-align: center;
            font-size: 1.2rem;
            color: var(--text-light);
            margin-bottom: 4rem;
            max-width: 600px;
            margin-left: auto;
            margin-right: auto;
        }

        .section-title::after {
            content: '';
            position: absolute;
            bottom: -15px;
            left: 50%;
            transform: translateX(-50%);
            width: 80px;
            height: 4px;
            background: var(--gradient-primary);
            border-radius: 2px;
        }

        /* Enhanced Cards */
        .card-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 2rem;
            margin-top: 3rem;
        }

        .enhanced-card {
            background: var(--white);
            padding: 2.5rem;
            border-radius: var(--border-radius);
            box-shadow: var(--shadow);
            transition: var(--transition-slow);
            position: relative;
            overflow: hidden;
            border: 1px solid var(--border-color);
            cursor: pointer;
        }

        .enhanced-card::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            height: 4px;
            background: var(--gradient-primary);
        }

        .enhanced-card:hover {
            transform: translateY(-10px) scale(1.02);
            box-shadow: var(--shadow-hover);
        }

        .enhanced-card:hover::before {
            height: 6px;
        }

        .card-icon {
            font-size: 3rem;
            margin-bottom: 1.5rem;
            background: var(--gradient-primary);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            text-align: center;
        }

        .card-title {
            font-size: 1.4rem;
            font-weight: 700;
            margin-bottom: 1rem;
            color: var(--text-color);
            text-align: center;
        }

        .card-description {
            color: var(--text-light);
            margin-bottom: 1.5rem;
            text-align: center;
            line-height: 1.6;
        }

        /* Enhanced Animations */
        @keyframes fadeInUp {
            from {
                opacity: 0;
                transform: translateY(40px);
            }
            to {
                opacity: 1;
                transform: translateY(0);
            }
        }

        @keyframes slideInLeft {
            from {
                opacity: 0;
                transform: translateX(-40px);
            }
            to {
                opacity: 1;
                transform: translateX(0);
            }
        }

        @keyframes slideInRight {
            from {
                opacity: 0;
                transform: translateX(40px);
            }
            to {
                opacity: 1;
                transform: translateX(0);
            }
        }

        @keyframes pulse {
            0% { transform: scale(1); }
            50% { transform: scale(1.05); }
            100% { transform: scale(1); }
        }

        @keyframes float {
            0%, 100% { transform: translateY(0px); }
            50% { transform: translateY(-10px); }
        }

        .fade-in-up {
            animation: fadeInUp 0.8s ease-out;
        }

        .slide-in-left {
            animation: slideInLeft 0.8s ease-out;
        }

        .slide-in-right {
            animation: slideInRight 0.8s ease-out;
        }

        .pulse-animation {
            animation: pulse 2s infinite;
        }

        .float-animation {
            animation: float 3s ease-in-out infinite;
        }

        .fade-in {
            opacity: 0;
            transform: translateY(30px);
            transition: var(--transition-slow);
        }

        .fade-in.visible {
            opacity: 1;
            transform: translateY(0);
        }

        /* Particle System */
        .hero-particles {
            position: absolute;
            width: 100%;
            height: 100%;
            overflow: hidden;
            top: 0;
            left: 0;
        }

        .particle {
            position: absolute;
            width: 4px;
            height: 4px;
            background: rgba(255, 255, 255, 0.6);
            border-radius: 50%;
            animation: particle-float 20s infinite linear;
            box-shadow: 0 0 10px rgba(255, 255, 255, 0.5);
        }

        @keyframes particle-float {
            0% { 
                transform: translateY(100vh) translateX(0px) rotate(0deg);
                opacity: 0;
            }
            10% { opacity: 1; }
            90% { opacity: 1; }
            100% { 
                transform: translateY(-100px) translateX(50px) rotate(360deg);
                opacity: 0;
            }
        }

        /* Enhanced Responsive Design */
        @media (max-width: 768px) {
            .nav-links {
                display: none;
                position: absolute;
                top: 100%;
                left: 0;
                width: 100%;
                background: var(--white);
                flex-direction: column;
                padding: 2rem;
                box-shadow: var(--shadow);
                border-radius: 0 0 var(--border-radius) var(--border-radius);
            }

            .nav-links.active {
                display: flex;
            }

            .nav-toggle {
                display: flex;
            }

            .hero {
                padding: 100px 0 60px;
                text-align: center;
            }

            .hero-stats {
                grid-template-columns: 1fr;
                gap: 1.5rem;
            }

            .section {
                padding: 60px 0;
            }

            .card-grid {
                grid-template-columns: 1fr;
                gap: 1.5rem;
            }

            .theme-toggle {
                top: 80px;
                right: 15px;
                width: 50px;
                height: 50px;
            }

            .floating-menu {
                bottom: 20px;
                right: 20px;
            }

            .floating-btn {
                width: 45px;
                height: 45px;
            }
        }

        @media (max-width: 480px) {
            .container {
                padding: 0 15px;
            }

            .enhanced-card {
                padding: 1.5rem;
            }

            .stats-counter {
                font-size: 2rem;
            }
        }

        /* Loading Animation */
        .loading {
            opacity: 0;
            animation: fadeInUp 1s ease-out forwards;
        }

        /* Smooth scrollbar */
        ::-webkit-scrollbar {
            width: 8px;
        }

        ::-webkit-scrollbar-track {
            background: var(--bg-color);
        }

        ::-webkit-scrollbar-thumb {
            background: var(--gradient-primary);
            border-radius: 4px;
        }

        ::-webkit-scrollbar-thumb:hover {
            background: var(--secondary-color);
        }

        /* Enhanced Form Styles */
        .form-control {
            width: 100%;
            padding: 15px 20px;
            border: 2px solid var(--border-color);
            border-radius: var(--border-radius-sm);
            font-size: 1rem;
            transition: var(--transition);
            font-family: inherit;
            background: var(--white);
            color: var(--text-color);
        }

        .form-control:focus {
            outline: none;
            border-color: var(--secondary-color);
            box-shadow: 0 0 0 3px rgba(59, 130, 246, 0.1);
            transform: translateY(-2px);
        }

        /* Special Category Colors */
        .kaggle-card::before { background: linear-gradient(135deg, #20beff 0%, #1565c0 100%); }
        .chess-card::before { background: linear-gradient(135deg, #795548 0%, #3e2723 100%); }
        .hardware-card::before { background: linear-gradient(135deg, #ff9800 0%, #e65100 100%); }
        .photography-card::before { background: linear-gradient(135deg, #9c27b0 0%, #4a148c 100%); }
        .club-sgipc::before { background: linear-gradient(135deg, #4caf50 0%, #1b5e20 100%); }
        .club-hack::before { background: linear-gradient(135deg, #ff5722 0%, #bf360c 100%); }

        /* Enhanced Typing Effect */
        .typing-cursor::after {
            content: '|';
            animation: blink 1s infinite;
            color: rgba(255, 255, 255, 0.8);
        }

        @keyframes blink {
            0%, 50% { opacity: 1; }
            51%, 100% { opacity: 0; }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Enhanced Theme Toggle -->
        <button type="button" class="theme-toggle" id="themeToggle" title="Toggle Dark/Light Theme">
            <i class="fas fa-moon" id="themeIcon"></i>
        </button>

        <!-- Floating Action Menu -->
        <div class="floating-menu">
            <a href="#contact" class="floating-btn" title="Contact Me">
                <i class="fas fa-envelope"></i>
            </a>
            <a href="#top" class="floating-btn" title="Back to Top">
                <i class="fas fa-arrow-up"></i>
            </a>
        </div>

        <!-- Enhanced Header -->
        <header class="header" id="header">
            <div class="container">
                <nav class="nav">
                    <a href="#home" class="logo">
                        <i class="fas fa-terminal"></i>
                        <span>Mahir Rahman</span>
                    </a>
                    <ul class="nav-links" id="navLinks">
                        <li><a href="#home">Home</a></li>
                        <li><a href="#about">About</a></li>
                        <li><a href="#skills">Skills</a></li>
                        <li><a href="#competitive">Programming</a></li>
                        <li><a href="#interests">Interests</a></li>
                        <li><a href="#clubs">Communities</a></li>
                        <li><a href="#projects">Projects</a></li>
                        <li><a href="#achievements">Achievements</a></li>
                        <li><a href="#education">Education</a></li>
                        <li><a href="#contact">Contact</a></li>
                    </ul>
                    <div class="nav-toggle" id="navToggle">
                        <span></span>
                        <span></span>
                        <span></span>
                    </div>
                </nav>
            </div>
        </header>

        <!-- Enhanced Hero Section -->
        <section id="home" class="hero">
            <div class="hero-particles" id="particles"></div>
            <div class="container">
                <div class="hero-content">
                    <h1 class="fade-in-up loading">
                        Hello, I'm <span class="text-gradient">Mahir Rahman</span>
                    </h1>
                    <h2 class="hero-subtitle typing-cursor" id="heroTitle">Competitive Programmer & Tech Enthusiast</h2>
                    <p class="hero-description fade-in-up loading">
                        CSE 3rd Year Student at KUET | Passionate Problem Solver | Hardware Project Builder | 
                        Kaggle Competitor | Chess Enthusiast | Photography Lover
                    </p>
                    <div class="hero-stats fade-in-up loading">
                        <div class="stat-card">
                            <span class="stats-counter" data-target="750">0</span>
                            <span class="stats-label">Problems Solved</span>
                        </div>
                        <div class="stat-card">
                            <span class="stats-counter" data-target="20">0</span>
                            <span class="stats-label">Competitions</span>
                        </div>
                        <div class="stat-card">
                            <span class="stats-counter" data-target="1456">0</span>
                            <span class="stats-label">Max Rating</span>
                        </div>
                    </div>
                    <a href="#contact" class="cta-button fade-in-up loading">
                        <i class="fas fa-rocket"></i>
                        <span>Let's Connect</span>
                    </a>
                </div>
            </div>
        </section>

        <!-- Enhanced About Section -->
        <section id="about" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    About <span class="highlight">Me</span>
                </h2>
                <p class="section-subtitle">
                    Passionate about technology, innovation, and creating impactful solutions
                </p>
                <div class="about-content">
                    <div class="slide-in-left">
                        <img src="Images/profile.jpg" alt="Mahir Rahman - Professional Profile" class="profile-img float-animation" 
                             onerror="this.src='https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=400&h=400&fit=crop&crop=face&auto=format&q=80'" />
                    </div>
                    <div class="about-text slide-in-right">
                        <p>
                            I'm a dedicated Computer Science and Engineering student at <strong>Khulna University of Engineering & Technology (KUET)</strong>, 
                            currently in my 3rd year. My journey is a fascinating blend of competitive programming excellence, hardware innovation, 
                            and creative exploration.
                        </p>
                        <p>
                            With <strong>750+ problems solved</strong> across multiple platforms, <strong>20+ competitions participated</strong>, 
                            and hands-on experience in robotics including <strong>obstacle-avoiding and line-following robots</strong>, 
                            I bridge the gap between theoretical computer science and practical engineering solutions.
                        </p>
                        <p>
                            As an active contributor to <strong>KUET Programming Club (SGIPC)</strong> and <strong>HACK (Hardware Acceleration Club)</strong>, 
                            I mentor fellow students while continuously expanding my expertise. Beyond coding, I'm passionate about chess strategy, 
                            Kaggle competitions, and capturing life through photography.
                        </p>
                        <div class="social-links">
                            <a href="https://linkedin.com/in/mahir-rahman" target="_blank" title="LinkedIn" class="pulse-animation">
                                <i class="fab fa-linkedin-in"></i>
                            </a>
                            <a href="https://github.com/k-i-mahi" target="_blank" title="GitHub">
                                <i class="fab fa-github"></i>
                            </a>
                            <a href="https://codeforces.com/profile/mahir_kuet" target="_blank" title="Codeforces">
                                <i class="fas fa-trophy"></i>
                            </a>
                            <a href="https://kaggle.com/mahirrahman" target="_blank" title="Kaggle">
                                <i class="fab fa-kaggle"></i>
                            </a>
                            <a href="https://chess.com/member/mahir_kuet" target="_blank" title="Chess.com">
                                <i class="fas fa-chess"></i>
                            </a>
                            <a href="mailto:mahir.rahman@kuet.ac.bd" title="Email">
                                <i class="fas fa-envelope"></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- Enhanced Skills Section -->
        <section id="skills" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    Technical <span class="highlight">Expertise</span>
                </h2>
                <p class="section-subtitle">
                    Comprehensive skills across multiple domains of technology
                </p>
                <div class="skills-grid" id="skillsGrid" runat="server">
                    <!-- Skills will be loaded dynamically from code-behind -->
                </div>
            </div>
        </section>

        <!-- Enhanced Competitive Programming Section -->
        <section id="competitive" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    Competitive <span class="highlight">Programming</span>
                </h2>
                <p class="section-subtitle">
                    My journey across various programming platforms and achievements
                </p>
                <div class="card-grid" id="programmingStats" runat="server">
                    <!-- Programming platform stats will be loaded dynamically -->
                </div>
            </div>
        </section>

        <!-- Enhanced Interests Section -->
        <section id="interests" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    Interests & <span class="highlight">Activities</span>
                </h2>
                <p class="section-subtitle">
                    Beyond programming - exploring diverse domains and creative pursuits
                </p>
                <div class="card-grid" id="interestsGrid" runat="server">
                    <!-- Interests will be loaded dynamically from code-behind -->
                </div>
            </div>
        </section>

        <!-- Enhanced Clubs Section -->
        <section id="clubs" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    Communities & <span class="highlight">Leadership</span>
                </h2>
                <p class="section-subtitle">
                    Active participation in technical communities and organizational leadership
                </p>
                <div class="card-grid" id="clubsGrid" runat="server">
                    <!-- Clubs will be loaded dynamically from code-behind -->
                </div>
            </div>
        </section>

        <!-- Enhanced Projects Section -->
        <section id="projects" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    Featured <span class="highlight">Projects</span>
                </h2>
                <p class="section-subtitle">
                    Innovative solutions spanning hardware, software, and data science
                </p>
                <div class="projects-grid">
                    <asp:Repeater ID="rptProjects" runat="server">
                        <ItemTemplate>
                            <article class="project-card enhanced-card">
                                <div class="project-img">
                                    <%# !string.IsNullOrEmpty(Eval("ImageUrl").ToString()) ? 
                                        $"<img src='{Eval("ImageUrl")}' alt='{Eval("Title")}' loading='lazy' />" : 
                                        "<i class='fas fa-laptop-code fa-3x'></i>" %>
                                </div>
                                <div class="project-content">
                                    <h3 class="project-title"><%# Eval("Title") %></h3>
                                    <p class="project-description"><%# Eval("Description") %></p>
                                    <%# !string.IsNullOrEmpty(Eval("DetailedDescription").ToString()) ? 
                                        $"<p class='project-detailed'>{Eval("DetailedDescription")}</p>" : "" %>
                                    <div class="project-tech">
                                        <i class="fas fa-tools"></i>
                                        <%# Eval("Technologies") %>
                                    </div>
                                    <div class="project-links">
                                        <%# !string.IsNullOrEmpty(Eval("GitHubLink").ToString()) ? 
                                            $"<a href='{Eval("GitHubLink")}' class='project-link' target='_blank' rel='noopener'><i class='fab fa-github'></i> Code</a>" : "" %>
                                        <%# !string.IsNullOrEmpty(Eval("LiveDemoLink").ToString()) ? 
                                            $"<a href='{Eval("LiveDemoLink")}' class='project-link' target='_blank' rel='noopener'><i class='fas fa-external-link-alt'></i> Demo</a>" : "" %>
                                    </div>
                                </div>
                            </article>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Enhanced Achievements Section -->
        <section id="achievements" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    Achievements & <span class="highlight">Recognition</span>
                </h2>
                <p class="section-subtitle">
                    Milestones and accomplishments across various platforms
                </p>
                <div class="achievements-grid">
                    <asp:Repeater ID="rptAchievements" runat="server">
                        <ItemTemplate>
                            <article class="achievement-card enhanced-card">
                                <div class="achievement-platform">
                                    <i class="fas fa-medal"></i>
                                    <%# Eval("Platform") %>
                                </div>
                                <h3 class="achievement-title"><%# Eval("Title") %></h3>
                                <p class="achievement-description"><%# Eval("Description") %></p>
                                <%# !string.IsNullOrEmpty(Eval("Ranking").ToString()) ? 
                                    $"<div class='achievement-ranking'><i class='fas fa-trophy'></i> {Eval("Ranking")}</div>" : "" %>
                                <small class="achievement-date">
                                    <i class="fas fa-calendar"></i>
                                    <%# Eval("AchievedDate", "{0:MMMM yyyy}") %>
                                </small>
                                <%# !string.IsNullOrEmpty(Eval("CertificateUrl").ToString()) ? 
                                    $"<br><a href='{Eval("CertificateUrl")}' target='_blank' rel='noopener' class='project-link' style='margin-top: 1rem; display: inline-block;'><i class='fas fa-certificate'></i> Certificate</a>" : "" %>
                            </article>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Enhanced Education Section -->
        <section id="education" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    Educational <span class="highlight">Journey</span>
                </h2>
                <p class="section-subtitle">
                    Academic excellence and continuous learning path
                </p>
                <div class="education-timeline">
                    <asp:Repeater ID="rptEducation" runat="server">
                        <ItemTemplate>
                            <article class="education-item enhanced-card">
                                <div class="education-header">
                                    <div class="education-info">
                                        <h3><%# Eval("Degree") %></h3>
                                        <h4><%# Eval("Institution") %></h4>
                                        <%# !string.IsNullOrEmpty(Eval("Department").ToString()) ? $"<p><strong>Department:</strong> {Eval("Department")}</p>" : "" %>
                                        <%# !string.IsNullOrEmpty(Eval("CGPA").ToString()) ? $"<p><strong>CGPA:</strong> {Eval("CGPA")}</p>" : "" %>
                                    </div>
                                    <div class="education-date">
                                        <i class="fas fa-calendar-alt"></i>
                                        <%# Eval("StartDate", "{0:yyyy}") %> - <%# Eval("IsCurrent").ToString() == "True" ? "Present" : Eval("EndDate", "{0:yyyy}") %>
                                    </div>
                                </div>
                                <%# !string.IsNullOrEmpty(Eval("Description").ToString()) ? $"<p class='education-description'>{Eval("Description")}</p>" : "" %>
                            </article>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>

        <!-- Enhanced Contact Section -->
        <section id="contact" class="section fade-in">
            <div class="container">
                <h2 class="section-title">
                    Let's <span class="highlight">Connect</span>
                </h2>
                <p class="section-subtitle">
                    Ready to collaborate on exciting projects or discuss opportunities
                </p>
                <div class="contact-content">
                    <asp:Panel ID="pnlMessage" runat="server" Visible="false">
                        <asp:Literal ID="litMessage" runat="server"></asp:Literal>
                    </asp:Panel>
                    
                    <div class="contact-form enhanced-card">
                        <div class="form-row">
                            <div class="form-group">
                                <label for="txtName">
                                    <i class="fas fa-user"></i>
                                    Full Name *
                                </label>
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" Required="true" placeholder="Your full name"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtEmail">
                                    <i class="fas fa-envelope"></i>
                                    Email Address *
                                </label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" Required="true" placeholder="your.email@example.com"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-row">
                            <div class="form-group">
                                <label for="txtPhone">
                                    <i class="fas fa-phone"></i>
                                    Phone Number
                                </label>
                                <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" placeholder="+880 1X XX XX XX XX"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtSubject">
                                    <i class="fas fa-tag"></i>
                                    Subject
                                </label>
                                <asp:TextBox ID="txtSubject" runat="server" CssClass="form-control" placeholder="What's this about?"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtMessage">
                                <i class="fas fa-comment"></i>
                                Message *
                            </label>
                            <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="6" Required="true" placeholder="Tell me about your project, idea, or just say hello..."></asp:TextBox>
                        </div>
                        <asp:Button ID="btnSubmit" runat="server" Text="Send Message" CssClass="btn-submit" OnClick="btnSubmit_Click" />
                    </div>
                </div>
            </div>
        </section>

        <!-- Enhanced Footer -->
        <footer class="footer">
            <div class="container">
                <div class="footer-content">
                    <div class="footer-text">
                        <p>&copy; <%= DateTime.Now.Year %> Mahir Rahman. Crafted with ?? using ASP.NET & C#</p>
                        <p>
                            <a href="Admin.aspx" style="color: rgba(255,255,255,0.7); text-decoration: none;">Admin Panel</a> |
                            <a href="mailto:mahir.rahman@kuet.ac.bd" style="color: rgba(255,255,255,0.7); text-decoration: none;">Contact</a>
                        </p>
                    </div>
                </div>
            </div>
        </footer>
    </form>

    <script>
        // Enhanced JavaScript with Performance Optimizations
        document.addEventListener('DOMContentLoaded', function() {
            // Initialize all components
            initializeTheme();
            initializeAnimations();
            initializeNavigation();
            initializeParticles();
            initializeCounters();
            initializeScrollEffects();
            initializeFormValidation();
            initializeTypingEffect();
            
            // Performance optimization: Use passive listeners
            const passiveEvent = { passive: true };
            
            // Theme Management
            function initializeTheme() {
                const savedTheme = localStorage.getItem('theme') || 'light';
                document.documentElement.setAttribute('data-theme', savedTheme);
                updateThemeIcon(savedTheme);
                
                const themeToggle = document.getElementById('themeToggle');
                if (themeToggle) {
                    themeToggle.addEventListener('click', toggleTheme);
                }
            }
            
            function toggleTheme() {
                const currentTheme = document.documentElement.getAttribute('data-theme');
                const newTheme = currentTheme === 'dark' ? 'light' : 'dark';
                
                document.documentElement.setAttribute('data-theme', newTheme);
                localStorage.setItem('theme', newTheme);
                updateThemeIcon(newTheme);
                
                // Add transition effect
                document.body.style.transition = 'background-color 0.3s ease, color 0.3s ease';
                setTimeout(() => {
                    document.body.style.transition = '';
                }, 300);
            }
            
            function updateThemeIcon(theme) {
                const themeIcon = document.getElementById('themeIcon');
                if (themeIcon) {
                    themeIcon.className = theme === 'dark' ? 'fas fa-sun' : 'fas fa-moon';
                }
            }
            
            // Enhanced Navigation
            function initializeNavigation() {
                const navToggle = document.getElementById('navToggle');
                const navLinks = document.getElementById('navLinks');
                const header = document.getElementById('header');
                
                if (navToggle && navLinks) {
                    navToggle.addEventListener('click', function() {
                        navLinks.classList.toggle('active');
                        navToggle.classList.toggle('active');
                    });
                    
                    // Close mobile menu when clicking on links
                    navLinks.addEventListener('click', function(e) {
                        if (e.target.tagName === 'A') {
                            navLinks.classList.remove('active');
                            navToggle.classList.remove('active');
                        }
                    });
                }
                
                // Header scroll effect with throttling
                let ticking = false;
                window.addEventListener('scroll', function() {
                    if (!ticking) {
                        requestAnimationFrame(function() {
                            if (window.scrollY > 50) {
                                header?.classList.add('scrolled');
                            } else {
                                header?.classList.remove('scrolled');
                            }
                            updateActiveNavLink();
                            ticking = false;
                        });
                        ticking = true;
                    }
                }, passiveEvent);
                
                // Smooth scrolling for navigation links
                document.querySelectorAll('a[href^="#"]').forEach(anchor => {
                    anchor.addEventListener('click', function (e) {
                        e.preventDefault();
                        const target = document.querySelector(this.getAttribute('href'));
                        if (target) {
                            const headerHeight = header?.offsetHeight || 70;
                            const targetPosition = target.offsetTop - headerHeight - 20;
                            
                            window.scrollTo({
                                top: targetPosition,
                                behavior: 'smooth'
                            });
                        }
                    });
                });
            }
            
            function updateActiveNavLink() {
                const sections = document.querySelectorAll('section[id]');
                const navLinks = document.querySelectorAll('.nav-links a');
                
                let current = '';
                sections.forEach(section => {
                    const rect = section.getBoundingClientRect();
                    if (rect.top <= 100 && rect.bottom >= 100) {
                        current = section.getAttribute('id');
                    }
                });
                
                navLinks.forEach(link => {
                    link.classList.remove('active');
                    if (link.getAttribute('href') === '#' + current) {
                        link.classList.add('active');
                    }
                });
            }
            
            // Enhanced Animations with Intersection Observer
            function initializeAnimations() {
                const observerOptions = {
                    threshold: 0.1,
                    rootMargin: '0px 0px -50px 0px'
                };
                
                const observer = new IntersectionObserver(function(entries) {
                    entries.forEach(entry => {
                        if (entry.isIntersecting) {
                            entry.target.classList.add('visible');
                            
                            // Trigger specific animations
                            if (entry.target.id === 'home') {
                                setTimeout(animateCounters, 500);
                            }
                            
                            // Animate skill bars
                            const skillBars = entry.target.querySelectorAll('.skill-progress');
                            skillBars.forEach((bar, index) => {
                                setTimeout(() => {
                                    const width = bar.getAttribute('data-width');
                                    if (width && !bar.classList.contains('animate')) {
                                        bar.style.width = width + '%';
                                        bar.classList.add('animate');
                                    }
                                }, index * 100);
                            });
                        }
                    });
                }, observerOptions);
                
                // Observe all sections and cards
                document.querySelectorAll('.fade-in, .enhanced-card').forEach(el => {
                    observer.observe(el);
                });
                
                // Add loading animations with stagger
                setTimeout(() => {
                    document.querySelectorAll('.loading').forEach((el, index) => {
                        setTimeout(() => {
                            el.style.animationDelay = (index * 0.1) + 's';
                            el.classList.add('fade-in-up');
                        }, index * 100);
                    });
                }, 100);
            }
            
            // Enhanced Particle System
            function initializeParticles() {
                const particles = document.getElementById('particles');
                if (particles) {
                    const particleCount = window.innerWidth > 768 ? 60 : 30;
                    
                    for (let i = 0; i < particleCount; i++) {
                        const particle = document.createElement('div');
                        particle.className = 'particle';
                        particle.style.left = Math.random() * 100 + '%';
                        particle.style.animationDelay = Math.random() * 20 + 's';
                        particle.style.animationDuration = (Math.random() * 15 + 15) + 's';
                        particle.style.opacity = Math.random() * 0.5 + 0.3;
                        particles.appendChild(particle);
                    }
                }
            }
            
            // Enhanced Counter Animation
            function initializeCounters() {
                const counters = document.querySelectorAll('.stats-counter');
                counters.forEach(counter => {
                    counter.innerText = '0';
                });
            }
            
            function animateCounters() {
                const counters = document.querySelectorAll('.stats-counter');
                counters.forEach((counter, index) => {
                    setTimeout(() => {
                        animateCounter(counter);
                    }, index * 200);
                });
            }
            
            function animateCounter(counter) {
                const target = parseInt(counter.getAttribute('data-target'));
                const duration = 2000;
                const start = performance.now();
                
                function updateCounter(currentTime) {
                    const elapsed = currentTime - start;
                    const progress = Math.min(elapsed / duration, 1);
                    
                    // Easing function for smooth animation
                    const easeOutCubic = 1 - Math.pow(1 - progress, 3);
                    const currentValue = Math.floor(target * easeOutCubic);
                    
                    counter.innerText = currentValue;
                    
                    if (progress < 1) {
                        requestAnimationFrame(updateCounter);
                    }
                }
                
                requestAnimationFrame(updateCounter);
            }
            
            // Scroll Effects
            function initializeScrollEffects() {
                // Parallax effect for hero section
                window.addEventListener('scroll', function() {
                    const scrolled = window.pageYOffset;
                    const hero = document.querySelector('.hero');
                    if (hero) {
                        hero.style.transform = `translateY(${scrolled * 0.5}px)`;
                    }
                }, passiveEvent);
            }
            
            // Enhanced Form Validation
            function initializeFormValidation() {
                const form = document.getElementById('form1');
                if (form) {
                    const requiredFields = form.querySelectorAll('[required]');
                    
                    requiredFields.forEach(field => {
                        field.addEventListener('blur', function() {
                            validateField(this);
                        });
                        
                        field.addEventListener('input', function() {
                            if (this.classList.contains('error')) {
                                validateField(this);
                            }
                        });
                    });
                }
            }
            
            function validateField(field) {
                const value = field.value.trim();
                const isValid = value !== '' && field.checkValidity();
                
                field.classList.remove('error', 'success');
                field.classList.add(isValid ? 'success' : 'error');
                
                field.style.borderColor = isValid ? 'var(--success-color)' : 'var(--accent-color)';
            }
            
            // Enhanced Typing Effect
            function initializeTypingEffect() {
                const heroTitle = document.getElementById('heroTitle');
                if (heroTitle && heroTitle.classList.contains('typing-cursor')) {
                    const phrases = [
                        'Competitive Programmer & Tech Enthusiast',
                        'Full-Stack Developer & Problem Solver',
                        'Hardware Project Builder & Innovator',
                        'Kaggle Competitor & Data Enthusiast'
                    ];
                    
                    let currentPhrase = 0;
                    let currentChar = 0;
                    let isDeleting = false;
                    
                    function type() {
                        const current = phrases[currentPhrase];
                        
                        if (isDeleting) {
                            heroTitle.textContent = current.substring(0, currentChar - 1);
                            currentChar--;
                        } else {
                            heroTitle.textContent = current.substring(0, currentChar + 1);
                            currentChar++;
                        }
                        
                        let typeSpeed = isDeleting ? 50 : 100;
                        
                        if (!isDeleting && currentChar === current.length) {
                            typeSpeed = 2000;
                            isDeleting = true;
                        } else if (isDeleting && currentChar === 0) {
                            isDeleting = false;
                            currentPhrase = (currentPhrase + 1) % phrases.length;
                            typeSpeed = 500;
                        }
                        
                        setTimeout(type, typeSpeed);
                    }
                    
                    setTimeout(type, 1000);
                }
            }
            
            // Enhanced Card Interactions
            document.querySelectorAll('.enhanced-card').forEach(card => {
                card.addEventListener('mouseenter', function() {
                    this.style.transform = 'translateY(-10px) scale(1.02)';
                });
                
                card.addEventListener('mouseleave', function() {
                    this.style.transform = 'translateY(0) scale(1)';
                });
            });
            
            // Keyboard Navigation Support
            document.addEventListener('keydown', function(e) {
                if (e.key === 'Escape') {
                    // Close mobile menu
                    const navLinks = document.getElementById('navLinks');
                    const navToggle = document.getElementById('navToggle');
                    if (navLinks && navLinks.classList.contains('active')) {
                        navLinks.classList.remove('active');
                        navToggle?.classList.remove('active');
                    }
                }
            });
            
            // Performance: Preload images
            const imageUrls = [
                'Images/profile.jpg',
                // Add other image URLs as needed
            ];
            
            imageUrls.forEach(url => {
                const img = new Image();
                img.src = url;
            });
            
            console.log('?? Portfolio initialized successfully!');
        });
    </script>
</body>
</html>