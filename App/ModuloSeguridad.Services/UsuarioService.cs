using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Services.Common;
using ModuloSeguridad.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSeguridad.Services
{
    public class UsuarioService : BaseService
    {
        public UsuarioService(ILogger logger, ModuloSeguridadContext context): base(logger, context)
        {
            
        }

        public async Task<Usuario> GetUsuarioAsync(string nombreUsuario, string clave)
        {
            try
            {
                logger.InicioMetodo("GetUsuarioAsync");
                logger.LogInformation("nombreUsuario: " + nombreUsuario);
                var hashHelper = new HashHelper();
                var usuario = context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.EstadoUsuario.Nombre == Enums.EstadoUsuarios.Activo.ToString());
                logger.LogInformation("usuario " + (usuario == null ? "no encontrado" : "encontrado"));
                if (usuario == null) return null;
                if (!hashHelper.CompareHash(clave, hashHelper.GenerateHash(clave))) return null;
                return usuario;
            }
            catch (Exception e)
            {
                logger.LogError(e, "Ocurrió un error en GetUsuarioAsync");
                return null;
            }
            finally
            {
                logger.FinMetodo("GetUsuarioAsync");
            }
        }
    }
}
