using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Data;
using PortfolioAPI.Models;

namespace PortfolioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProjectsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/projects
        // React ko saare projects milenge yahan se
        [HttpGet]
        public IActionResult GetProjects()
        {
            var projects = _context.Projects.ToList();
            return Ok(projects);
        }

        // POST: api/projects
        // Naya project add karne ke liye
        [HttpPost]
        public async Task<IActionResult> AddProject([FromBody] Project project)
        {
            if (string.IsNullOrEmpty(project.Title))
                return BadRequest(new { error = "Title required hai" });

            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return Ok(new { success = true, project });
        }
    }
}