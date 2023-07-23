using ModuloSeguridad.Services;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models.Usuarios
{
    public class UsuarioCambiarClaveViewModel
    {
        [Required(ErrorMessageResourceName = nameof(ValidationMessages.Required), ErrorMessageResourceType = typeof(ValidationMessages))]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        [Display(Name ="Clave Actual")]
        [DataType(DataType.Password)]
        public string ClaveActual { get; set; }

        [Required(ErrorMessageResourceName = nameof(ValidationMessages.Required), ErrorMessageResourceType = typeof(ValidationMessages))]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        [Display(Name ="Clave Nueva")]
        [DataType(DataType.Password)]
        public string ClaveNueva { get; set; }

        [Required(ErrorMessageResourceName = nameof(ValidationMessages.Required), ErrorMessageResourceType = typeof(ValidationMessages))]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        [Compare(nameof(ClaveNueva), ErrorMessageResourceName =nameof(ValidationMessages.EqualTo), ErrorMessageResourceType =typeof(ValidationMessages))]
        [Display(Name ="Confirmar Clave Nueva")]
        [DataType(DataType.Password)]
        public string ClaveNuevaConfirmada { get; set; }
    }
}
