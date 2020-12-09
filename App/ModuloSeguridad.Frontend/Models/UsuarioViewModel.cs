using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models
{
    public class UsuarioViewModel : BaseViewModel
    {
        [Display(Name = nameof(Usuario))]
        [Required(ErrorMessageResourceType =typeof(ValidationMessages), ErrorMessageResourceName =nameof(ValidationMessages.Required))]
        public string NombreUsuario { get; set; }

        [MaxLength(50, ErrorMessage = "Por favor, no escribas más de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "Por favor, no escribas más de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Por favor, no escribas más de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        [DataType(DataType.EmailAddress, ErrorMessageResourceType =typeof(ValidationMessages), ErrorMessageResourceName =nameof(ValidationMessages.Email))]
        public string Mail { get; set; }

        public List<AccionModulo> AccionModulos { get; set; }

        public class AccionModulo
        {
            public string Accion { get; set; }
            public string Modulo { get; set; }
        }
    }
}
