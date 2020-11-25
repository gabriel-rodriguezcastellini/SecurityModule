using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class BaseEntity
    {
        public bool Eliminado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public DateTime? FechaEliminacion { get; set; }

        public string CreadoPor { get; set; }

        public string ActualizadoPor { get; set; }

        public string EliminadoPor { get; set; }
    }
}
