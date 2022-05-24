using Microsoft.AspNetCore.Mvc;

namespace Migan.Controllers
{
    public class FacturaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
