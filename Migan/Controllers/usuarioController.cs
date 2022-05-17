using Microsoft.AspNetCore.Mvc;
using Migan.Models;

namespace Migan.Controllers
{
    [Route("usuarioController")]
    public class usuarioController : Controller
    {

        public MIGANContext _context;

        public usuarioController(MIGANContext master)
        {
            this._context = master;
        }

        //[Route("")]
        //[Route("index")]
        //[Route("~/")]
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string nombreUsuario, string passwordUsuario)
        {
            var usuario = _context.Usuarios.Where(s => s.Usuario1 == nombreUsuario && s.Contrasena == passwordUsuario);
            if (usuario.Any())
            {
                if (usuario.Where(s => s.Usuario1 == nombreUsuario && s.Contrasena == passwordUsuario).Any())
                {
                    return Json(new { status = true, message = $"Bienvenido {nombreUsuario}" });
                }
                else
                {
                    return Json(new { status = false, message = "Usuario o contraseña invalido" });
                }

            }
            else
            {
                return Json(new { status = false, message = "Usuario o contraseña invalido" });
            }
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}
