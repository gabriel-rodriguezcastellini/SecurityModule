using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloSeguridad.Services.Common
{
    public class Enums
    {
        public enum EstadoUsuarios
        {
            /// <summary>
            /// Usado solo para las vistas
            /// </summary>
            Todos,
            Activo,
            Inactivo
        }

        public enum EstadoGrupos
        {
            Activo,
            Inactivo
        }
    }
}
