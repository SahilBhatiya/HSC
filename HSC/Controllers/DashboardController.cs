using Microsoft.AspNetCore.Mvc;

namespace HSC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
