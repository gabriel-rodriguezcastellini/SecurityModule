using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Services.Common;
using ModuloSeguridad.Services.Extensions.Mail;
using NETCore.Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ModuloSeguridad.Services.Common.Enums;

namespace ModuloSeguridad.Services
{
    public class UsuarioService : BaseService
    {
        private readonly MailSender mailSender;

        public UsuarioService(ILogger logger, ModuloSeguridadContext context, MailSender mailSender): base(logger, context)
        {
            this.mailSender = mailSender;
        }

        public async Task<Usuario> GetUsuarioAsync(string nombreUsuario, string clave)
        {
            try
            {
                logger.InicioMetodo("GetUsuarioAsync");
                logger.LogInformation("nombreUsuario: " + nombreUsuario);
                var usuario = await context.Usuarios
                    .OrderBy(u=>u.NombreUsuario)
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

        public async Task<IQueryable<Usuario>> GetUsuariosAsync(string usuarioActual = null, string apellidoNombre = null, int? grupoId = null, EstadoUsuarios estado = EstadoUsuarios.Todos)
        {
            var usuarios = (await context.Usuarios.Include(u => u.EstadoUsuario).Include(u => u.UsuarioGrupos).ThenInclude(ug => ug.Grupo).ToListAsync()).AsQueryable();
            if (!string.IsNullOrEmpty(usuarioActual)) usuarios = usuarios.Where(u => u.NombreUsuario != usuarioActual);
            if (!string.IsNullOrEmpty(apellidoNombre))
            {
                apellidoNombre = apellidoNombre.Trim().ToLower();
                usuarios = usuarios.Where(u => u.Apellido.ToLower().Contains(apellidoNombre) || u.Nombre.ToLower().Contains(apellidoNombre));
            }
            if (grupoId != null) usuarios = usuarios.ToList().Where(u => u.UsuarioGrupos?.Any(ug => ug.GrupoId == (int)grupoId) == true).AsQueryable();
            if (estado != EstadoUsuarios.Todos) usuarios = usuarios.Where(u => u.EstadoUsuario.Nombre == estado.ToString());
            return usuarios.AsQueryable();
        }

        public async Task<Usuario> GetUsuarioAsync(string nombreUsuario)
        {
            return await context.Usuarios.OrderBy(u=>u.NombreUsuario).Include(u=>u.EstadoUsuario)
                .Include(u => u.UsuarioGrupos).ThenInclude(ug=>ug.Grupo).SingleOrDefaultAsync(u=>u.NombreUsuario == nombreUsuario);
        }

        public bool TienePermisoAccionModulo(string nombreUsuario, string accion, string modulo)
        {
            return context.Usuarios.OrderBy(u => u.NombreUsuario).Include(u=>u.UsuarioGrupos)
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
            return context.Usuarios.AsNoTracking().OrderBy(u=>u.NombreUsuario).Include(u => u.UsuarioGrupos)
                .ThenInclude(ug => ug.Grupo)
                .ThenInclude(g => g.GrupoAccionModulos)
                .ThenInclude(gam => gam.AccionModulo)
                .ThenInclude(am => am.Modulo)
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario)?.UsuarioGrupos
                ?.Any(ug => ug.Grupo.GrupoAccionModulos.Any(gam => gam.AccionModulo?.Modulo?.Nombre == modulo)) == true;
        }        

        public async Task<bool> UsuarioExiste(string nombreUsuario)
        {
            return await context.Usuarios.AnyAsync(e => e.NombreUsuario == nombreUsuario);
        }

        public async Task<bool> UsuarioExiste(string nombreUsuario, string mail)
        {
            return await context.Usuarios.AnyAsync(e => e.NombreUsuario == nombreUsuario && e.Mail == mail && e.EstadoUsuario.Nombre == EstadoUsuarios.Activo.ToString());
        }

        public async Task Agregar(Usuario usuario)
        {
            context.NombreUsuario = usuario.NombreUsuario;
            var clave = new Random().Next(1000, 9999).ToString();
            usuario.Clave = EncryptProvider.Md5(clave);
            await context.Usuarios.AddAsync(usuario);
            await context.SaveChangesAsync();
            await ResetearClave(usuario.NombreUsuario, "Bienvenido", true, clave);
        }

        public async Task ResetearClave(string nombreUsuario, string asunto = null, bool bienvenida = true, string clave = null)
        {
            context.NombreUsuario = nombreUsuario;
            var nuevaClave = string.IsNullOrEmpty(clave) ? new Random().Next(1000, 9999).ToString() : clave;
            var usuario = await context.Usuarios.FindAsync(nombreUsuario);
            usuario.Clave = EncryptProvider.Md5(nuevaClave);
            context.Usuarios.Update(usuario);
            await context.SaveChangesAsync();
            await mailSender.EnviarMailAsync(new Message(usuario.Mail, asunto, string.Format(string.Concat("Tu ", bienvenida ? "clave" : "nueva clave", " es: {0}"), nuevaClave)));
        }

        public async Task<bool> Eliminar(string nombreUsuario)
        {
            if (!await UsuarioExiste(nombreUsuario)) return false;
            context.Usuarios.Remove(await context.Usuarios.FindAsync(nombreUsuario));
            await context.SaveChangesAsync();
            return true;
        }

        public async Task Modificar(Usuario usuario)
        {
            context.NombreUsuario = usuario.NombreUsuario;
            if (!await UsuarioExiste(usuario.NombreUsuario)) return;
            context.Usuarios.Update(usuario);
            await context.SaveChangesAsync();
        }

        public async Task<bool> EsContraseniaCorrecta(string nombreUsuario, string clave)
        {
            return (await context.Usuarios.FindAsync(nombreUsuario))?.Clave == EncryptProvider.Md5(clave);
        }

        public async Task AgregarUsuariosGrupo(int grupoId, List<string> nombreUsuarios, string nombreUsuarioActual)
        {
            context.NombreUsuario = nombreUsuarioActual;
            context.UsuarioGrupos.RemoveRange(await context.UsuarioGrupos.Where(ug => ug.GrupoId == grupoId).ToListAsync());
            foreach (var item in nombreUsuarios)
            {
                context.UsuarioGrupos.Add(new UsuarioGrupo() { Grupo = await context.Grupos.FindAsync(grupoId), Usuario = await context.Usuarios.FindAsync(item) });
            }
            await context.SaveChangesAsync();
        }
    }
}