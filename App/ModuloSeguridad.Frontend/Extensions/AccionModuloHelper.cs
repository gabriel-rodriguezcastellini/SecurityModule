using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Extensions
{
    public class AccionModuloHelper
    {
        private readonly ILogger logger;
        public AccionModuloHelper(ILogger logger)
        {
            this.logger = logger;
        }
        public void GuardarAccionesModulos(List<UsuarioGrupo> usuarioGrupos, ref List<AccionModulo> accionModulos)
        {
            foreach (var usuarioGrupo in usuarioGrupos)
            {
                foreach (var accionModulo in usuarioGrupo.Grupo.GrupoAccionModulos.Select(gam => gam.AccionModulo).Distinct())
                {
                    if (!accionModulos.Contains(accionModulo))
                    {
                        logger.LogInformation("Agregando módulo {0} y acción {1} a la lista de acciones del usuario", accionModulo.Modulo.Nombre, accionModulo.Accion.Nombre);
                        accionModulos.Add(accionModulo);
                    }
                }
            }
        }
    }
}