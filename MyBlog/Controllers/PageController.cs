using MyBlog.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data;


namespace FineBlog.Controllers
{
    public class PageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> About()
        {
           
            return View();
        }

        public async Task<IActionResult> Contact()
        {
            
            return View();
        }

        public async Task<IActionResult> PrivacyPolicy()
        {
            
            return View();
        }
    }
}
