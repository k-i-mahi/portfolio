using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        
        [StringLength(2000)]
        public string DetailedDescription { get; set; }
        
        [StringLength(200)]
        public string Technologies { get; set; }
        
        [StringLength(500)]
        public string GitHubLink { get; set; }
        
        [StringLength(500)]
        public string LiveDemoLink { get; set; }
        
        [StringLength(500)]
        public string ImageUrl { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public bool IsActive { get; set; }
        
        public int DisplayOrder { get; set; }
    }
    
    public class Skill
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(20)]
        public string Category { get; set; } // Programming, Database, Framework, Tool
        
        public int ProficiencyLevel { get; set; } // 1-100
        
        [StringLength(500)]
        public string IconClass { get; set; }
        
        public bool IsActive { get; set; }
        
        public int DisplayOrder { get; set; }
    }
    
    public class Achievement
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        
        [StringLength(100)]
        public string Platform { get; set; } // CodeChef, Codeforces, HackerRank, etc.
        
        [StringLength(500)]
        public string Description { get; set; }
        
        [StringLength(50)]
        public string Ranking { get; set; }
        
        [StringLength(500)]
        public string CertificateUrl { get; set; }
        
        public DateTime AchievedDate { get; set; }
        
        public bool IsActive { get; set; }
        
        public int DisplayOrder { get; set; }
    }
    
    public class Education
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Institution { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Degree { get; set; }
        
        [StringLength(100)]
        public string Department { get; set; }
        
        [StringLength(20)]
        public string CGPA { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime? EndDate { get; set; }
        
        public bool IsCurrent { get; set; }
        
        [StringLength(1000)]
        public string Description { get; set; }
        
        public bool IsActive { get; set; }
        
        public int DisplayOrder { get; set; }
    }
    
    public class Contact
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        
        [StringLength(20)]
        public string Phone { get; set; }
        
        [StringLength(100)]
        public string Subject { get; set; }
        
        [Required]
        [StringLength(2000)]
        public string Message { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public bool IsRead { get; set; }
    }
}