using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace Presentacion.Filtros
{
    public class AuthAdmin : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("Rol") != "Administrador")
            {
                context.Result = new RedirectResult("~/Usuario/Home");
            }
        }
    }
}
