using Microsoft.AspNetCore.Http;
using ModuloSeguridad.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Authorization
{
    public static class Cookie
    {
        public static UsuarioViewModel GetUsuarioViewModel(HttpContext httpContext)
        {
            return new UsuarioViewModel()
            {
                NombreUsuario = httpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value,
                Nombre = httpContext.User.FindFirst(ClaimTypes.Name)?.Value,
                Apellido = httpContext.User.FindFirst(ClaimTypes.Surname)?.Value,
                Mail = httpContext.User.FindFirst(ClaimTypes.Email)?.Value
            };
        }
    }
}
