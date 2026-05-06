namespace PortfolioAPI.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TechStack { get; set; } = string.Empty;
        public string LiveUrl { get; set; } = string.Empty;
        public string GithubUrl { get; set; } = string.Empty;
        public string Color { get; set; } = "#5DCAA5";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}