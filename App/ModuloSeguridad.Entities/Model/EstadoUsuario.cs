using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModuloSeguridad.Entities.Model
{
    public class EstadoUsuario : BaseEntity
    {
        public int EstadoUsuarioId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Required))]
        [MaxLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; }

        public List<Usuario> Usuarios { get; set; }
    }
}
