using Microsoft.AspNetCore.Mvc;
using PortfolioAPI.Data;
using PortfolioAPI.Models;

namespace PortfolioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/contact
        // React form se message aayega yahan
        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] ContactMessage msg)
        {
            if (string.IsNullOrEmpty(msg.Name) ||
                string.IsNullOrEmpty(msg.Email) ||
                string.IsNullOrEmpty(msg.Message))
            {
                return BadRequest(new { error = "Sab fields required hain" });
            }

            msg.CreatedAt = DateTime.UtcNow;
            _context.ContactMessages.Add(msg);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Message save ho gaya!" });
        }

        // GET: api/contact
        // Saare messages dekhne ke liye
        [HttpGet]
        public async Task<IActionResult> GetMessages()
        {
            var messages = _context.ContactMessages.ToList();
            return Ok(messages);
        }
    }
}