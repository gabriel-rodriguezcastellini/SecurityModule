using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace ModuloSeguridad.Services
{
    public class UsuarioService : BaseService
    {
        public UsuarioService(ILogger logger, ModuloSeguridadContext context): base(logger, context)
        {
            
        }

        //public async Task<Usuario> GetUsuarioAsync(string nombreUsuario, string clave)
        //{
        //    //BCrypt.Net.BCrypt.HashPassword(clave);
        //    var usuario = context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Clave == clave);
        //    logger.LogInformation("usuario " + (usuario != null ? " encontrado" : " no encontrado"));
        //    BCrypt.Net.BCrypt.Verify()

        //}
    }
}
