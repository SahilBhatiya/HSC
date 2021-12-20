using Microsoft.AspNetCore.Mvc;

namespace HSC.Controllers
{
    public class NavbarController : Controller
    {
        public IActionResult _Dashboard()
        {
            return View();
        }
    }
}
