using Microsoft.AspNetCore.Mvc;

namespace FukLinux.Controllers
{
    public class HealthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
