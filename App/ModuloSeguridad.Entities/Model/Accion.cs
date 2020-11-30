using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class Accion : BaseEntity
    {
        public int AccionId { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Required))]
        public string Nombre { get; set; }        

        public List<GrupoAccion> GrupoAcciones { get; set; }        
    }
}
