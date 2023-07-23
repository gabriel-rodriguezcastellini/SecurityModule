using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuloSeguridad.Entities.Model
{
    public class Usuario : BaseEntity
    {
        [Key]
        [Required]
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
        [MinLength(3)]
        public string Clave { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        public int EstadoUsuarioId { get; set; }

        [ForeignKey(nameof(EstadoUsuarioId))]
        public EstadoUsuario EstadoUsuario { get; set; }

        public List<UsuarioGrupo> UsuarioGrupos { get; set; }
    }
}
