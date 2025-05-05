using ClinicApp3.Contexts;
using ClinicApp3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp3.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<HealthCareSolution> healthCareSolutions = _context.HealthCareSolutions.ToList();
            return View(healthCareSolutions);
        }
    }
}
