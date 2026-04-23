using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace Presentacion.Filtros
{
    public class AuthCoordinador : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string rol = context.HttpContext.Session.GetString("Rol");
            if (rol != "Coordinador" && rol != "Administrador")
            {
                context.Result = new RedirectResult("~/Usuario/Login");
            }
        }
    }
}
