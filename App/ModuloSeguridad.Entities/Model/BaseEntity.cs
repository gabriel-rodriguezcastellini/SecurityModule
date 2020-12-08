using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
