using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Models.Usuarios
{
    public class UsuarioModificarViewModel
    {
        public string NombreUsuario { get; set; }

        [MaxLength(50, ErrorMessage = "Por favor, no escribas más de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        public string Apellido { get; set; }

        [MaxLength(50, ErrorMessage = "Por favor, no escribas más de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessageResourceName = nameof(ValidationMessages.Required), ErrorMessageResourceType = typeof(ValidationMessages))]
        [MaxLength(50, ErrorMessage = "Por favor, no escribas más de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Mail { get; set; }

        [Display(Name = "Estado")]
        public bool Activo { get; set; }

        public List<Grupo> Grupos { get; set; }

        public class Grupo
        {
            public int GrupoId { get; set; }

            public string Nombre { get; set; }

            public bool Checked { get; set; }
        }
    }
}
