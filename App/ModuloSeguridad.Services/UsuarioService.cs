﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Services.Common;
using NETCore.Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSeguridad.Services
{
    public class UsuarioService : BaseService
    {
        public UsuarioService(ILogger logger, ModuloSeguridadContext context): base(logger, context)
        {
            
        }

        public Usuario GetUsuario(string nombreUsuario, string clave)
        {
            try
            {
                logger.InicioMetodo(MethodBase.GetCurrentMethod().Name);
                logger.LogInformation("nombreUsuario: " + nombreUsuario);
                var usuario = context.Usuarios
                    .Include(u=>u.UsuarioGrupos)
                    .ThenInclude(ug=>ug.Grupo)
                    .ThenInclude(g=>g.GrupoAccionModulos)
                    .ThenInclude(gam=>gam.AccionModulo)
                    .ThenInclude(am=>am.Accion)

                    //Esto es para que se pueda navegar de AccionModulo a Modulo
                    .Include(u => u.UsuarioGrupos)
                    .ThenInclude(ug => ug.Grupo)
                    .ThenInclude(g => g.GrupoAccionModulos)
                    .ThenInclude(gam => gam.AccionModulo)
                    .ThenInclude(am => am.Modulo)

                    .FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.EstadoUsuario.Nombre == Enums.EstadoUsuarios.Activo.ToString() && !u.Eliminado);
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
                logger.InicioMetodo(MethodBase.GetCurrentMethod().Name);
            }
        }

        public bool TienePermisoAccion(string nombreUsuario, string accion, string modulo)
        {
            if (context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario)?.UsuarioGrupos
                .Any(ug => ug.Grupo.GrupoAccionModulos.
                Any(gam => gam.AccionModulo.Accion.Nombre == accion && gam.AccionModulo.Modulo.Nombre == modulo)) == true) return true;
            return false;
        }
    }
}
