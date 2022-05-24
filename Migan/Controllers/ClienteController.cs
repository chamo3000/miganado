using Microsoft.AspNetCore.Mvc;

namespace Migan.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
