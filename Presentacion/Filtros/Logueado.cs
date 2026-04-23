using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace Presentacion.Filtros
{
    public class Logueado : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("Rol") == null)
            {
                context.Result = new RedirectResult("~/Usuario/Login");
            }
        }
    }
}