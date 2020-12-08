using Microsoft.AspNetCore.Http;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Frontend.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Claims;

namespace ModuloSeguridad.Frontend.Authorization
{
    public static class Cookie
    {
        public static UsuarioViewModel GetUsuarioViewModel(ClaimsPrincipal user)
        {
            return new UsuarioViewModel()
            {
                NombreUsuario = user.Identity?.Name,
                Nombre = user.FindFirst(ClaimTypes.Name)?.Value,
                Apellido = user.FindFirst(ClaimTypes.Surname)?.Value,
                Mail = user.FindFirst(ClaimTypes.Email)?.Value,
                AccionModulos = JsonConvert.DeserializeObject<List<UsuarioViewModel.AccionModulo>>(user.FindFirst(ClaimTypes.UserData)?.Value)
            };
        }
    }
}
