using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Extensions
{
    public static class AccionModuloHelper
    {                
        public static void GuardarModulos(List<UsuarioGrupo> usuarioGrupos, ref List<UsuarioViewModel.AccionModulo> accionModulos)
        {
            foreach (var usuarioGrupo in usuarioGrupos)
            {
                foreach (var accionModulo in usuarioGrupo.Grupo.GrupoAccionModulos.Select(gam => gam.AccionModulo).Distinct())
                {
                    if (!accionModulos.Any(am=>am.Modulo == accionModulo.Modulo.Nombre && am.Accion == accionModulo.Accion.Nombre))
                    {
                        accionModulos.Add(new UsuarioViewModel.AccionModulo() { Accion = accionModulo.Accion.Nombre, Modulo = accionModulo.Modulo.Nombre });
                    }
                }
            }
        }
    }
}