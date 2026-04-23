using CasosUso.DTOs;
using CasosUso.InterfacesCU;
using LogicaAplicacion.DTOs;
using LogicaAplicacion.InterfacesCasosUso;
using LogicaNegocio.InterfacesRepositorio;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Presentacion.Controllers
{
    public class UsuarioController : Controller
    {
        //readonly 
        public IRepositorioUsuarios RepoUsuarios { get; set; }

        public ILogin CULogin { get; set; }
        public ICUAltaUsuario CUAltaUsuario { get; set; }

        public UsuarioController(ILogin cuLogin, ICUAltaUsuario cuAltaUsuario, IRepositorioUsuarios repoUsuarios)
        {
            CULogin = cuLogin;
            CUAltaUsuario = cuAltaUsuario;
            RepoUsuarios = repoUsuarios;
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
                return View("Home");
            }
        }

      
        public IActionResult Alta()
        {
            // Solo puede entrar si es Administrador 
            string rol = HttpContext.Session.GetString("rol");

            if (rol != "Administrador")
            {
                //Cambiar el Login por una view que de error al no ser admin
                return RedirectToAction("ListaAlta", "Usuario");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Alta(AltaUsuarioDTO dto)
        {
            try
            {
                // llamamos al caso de uso para validar y mapear
                CUAltaUsuario.EjecutarAlta(dto);
                TempData["MensajeExito"] = "El usuario fue creado correctamente.";
                return RedirectToAction("ListaAlta");
            }
            catch (Exception ex)
            {
                // guardamos la excepcion en el ViewBag.Error
                ViewBag.Error = ex.Message;

                // Le devolvemos el DTO a la vista 
                return View(dto);
            }
        }



        public IActionResult ListaAlta()
        {
            string rol = HttpContext.Session.GetString("rol");
            if (string.IsNullOrEmpty(rol))
            {
                return RedirectToAction("Login");
            }
            var listaUsuarios = RepoUsuarios.FindAll();


            return View(listaUsuarios);
        }






    }
}