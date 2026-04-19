using CasosUso.InterfacesCU;
using CasosUso.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    public class UsuarioController : Controller
    {
        public class UsuariosController : Controller
        {
            public ILogin CULogin { get; set; }

            public UsuariosController(ILogin cuLogin)
            {
                CULogin = cuLogin;
            }


            public IActionResult Index()
            {
                string rol = HttpContext.Session.GetString("rol");
                if (string.IsNullOrEmpty(rol))
                {
                    return RedirectToAction("Login");
                }
                return View("Home");
            }

            public IActionResult Login()
            {
                return View();
            }

            public IActionResult Logout()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }

            [HttpPost]
            public IActionResult Login(UsuarioDTO dto)
            {
                UsuarioDTO usuarioLogueado = CULogin.EjecutarLogin(dto.Email, dto.Password);
                if (usuarioLogueado == null)
                {
                    ViewBag.Error = "El email o la contraseña son incorrectos";
                    return View(dto);
                }
                else
                {
                    HttpContext.Session.SetString("rol", usuarioLogueado.Rol);
                    return RedirectToAction("Index", "Temas");
                }
            }
        }
    }
}