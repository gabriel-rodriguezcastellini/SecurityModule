using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class Modulo : BaseEntity
    {
        public int ModuloId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Required))]
        [MaxLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; }                
    }
}
