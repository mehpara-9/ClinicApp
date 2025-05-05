using Microsoft.AspNetCore.Mvc;

namespace ClinicApp3.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
