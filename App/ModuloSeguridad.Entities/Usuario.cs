using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class Usuario : EntidadBase
    {
        [Key]
        [Required(ErrorMessageResourceType =typeof(Validaciones), ErrorMessageResourceName =nameof(Validaciones.Requerido))]
        [MaxLength(50)]
        [MinLength(3)]
        public string NombreUsuario { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Clave { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Mail { get; set; }

        public int EstadoUsuarioId { get; set; }

        [ForeignKey(nameof(EstadoUsuarioId))]
        public EstadoUsuario EstadoUsuario { get; set; }

        public List<UsuarioGrupo> UsuarioGrupos { get; set; }
    }
}
