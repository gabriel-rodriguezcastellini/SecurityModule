using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Services.Common;
using NETCore.Encrypt;
using System;
using System.Linq;
using System.Reflection;
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
                var usuario = await context.Usuarios
                    .Include(u => u.UsuarioGrupos)
                    .ThenInclude(ug => ug.Grupo)
                    .ThenInclude(g => g.GrupoAccionModulos)
                    .ThenInclude(gam => gam.AccionModulo)
                    .ThenInclude(am => am.Accion)

                    //Esto es para que se pueda navegar de AccionModulo a Modulo
                    .Include(u => u.UsuarioGrupos)
                    .ThenInclude(ug => ug.Grupo)
                    .ThenInclude(g => g.GrupoAccionModulos)
                    .ThenInclude(gam => gam.AccionModulo)
                    .ThenInclude(am => am.Modulo)

                    .FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario && u.EstadoUsuario.Nombre == Enums.EstadoUsuarios.Activo.ToString());
                logger.LogInformation("usuario " + (usuario == null ? "no encontrado" : usuario.NombreUsuario + "encontrado"));
                if (usuario == null) return null;
                if (EncryptProvider.Md5(clave) != usuario.Clave) return null;
                return usuario;
            }
            catch (Exception e)
            {
                logger.LogError(e, "Ocurrió un error en GetUsuarioAsync");
                return null;
            }
            finally
            {
                logger.InicioMetodo("GetUsuarioAsync");
            }
        }        

        public bool TienePermisoAccionModulo(string nombreUsuario, string accion, string modulo)
        {
            return context.Usuarios.Include(u=>u.UsuarioGrupos)
                .ThenInclude(ug=>ug.Grupo)
                .ThenInclude(g=>g.GrupoAccionModulos)
                .ThenInclude(gam=>gam.AccionModulo)
                .ThenInclude(am=>am.Accion)

                .Include(u => u.UsuarioGrupos)
                .ThenInclude(ug => ug.Grupo)
                .ThenInclude(g => g.GrupoAccionModulos)
                .ThenInclude(gam => gam.AccionModulo)
                .ThenInclude(am => am.Modulo)

                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario)?.UsuarioGrupos
                ?.Any(ug => ug.Grupo.GrupoAccionModulos.Any(gam => gam.AccionModulo?.Accion?.Nombre == accion && gam.AccionModulo?.Modulo?.Nombre == modulo)) == true;
        }

        public bool TienePermisoModulo(string nombreUsuario, string modulo)
        {
            return context.Usuarios.Include(u => u.UsuarioGrupos)
                .ThenInclude(ug => ug.Grupo)
                .ThenInclude(g => g.GrupoAccionModulos)
                .ThenInclude(gam => gam.AccionModulo)
                .ThenInclude(am => am.Modulo)
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario)?.UsuarioGrupos
                ?.Any(ug => ug.Grupo.GrupoAccionModulos.Any(gam => gam.AccionModulo?.Modulo?.Nombre == modulo)) == true;
        }

        public async Task<IQueryable<Usuario>> GetUsuariosAsync(string usuarioActual)
        {
            return (await context.Usuarios.Where(u=>u.NombreUsuario != usuarioActual)
                .Include(u => u.EstadoUsuario).Include(u=>u.UsuarioGrupos).ThenInclude(ug=>ug.Grupo).ToListAsync()).AsQueryable();
        }
    }
}