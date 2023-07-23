using System;

namespace ModuloSeguridad.Entities.Model
{
    public class BaseEntity
    {
        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public string CreadoPor { get; set; }

        public string ActualizadoPor { get; set; }
    }
}
