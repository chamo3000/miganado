using Microsoft.AspNetCore.Mvc;

namespace Migan.Controllers
{
    public class ClaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
