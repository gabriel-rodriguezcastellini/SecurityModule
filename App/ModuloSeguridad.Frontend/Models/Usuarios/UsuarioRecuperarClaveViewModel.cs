using ModuloSeguridad.Services;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models.Usuarios
{
    public class UsuarioRecuperarClaveViewModel
    {
        [Required(ErrorMessageResourceName = nameof(ValidationMessages.Required), ErrorMessageResourceType = typeof(ValidationMessages))]
        public string Usuario { get; set; }

        [Display(Name ="E-mail")]
        [Required(ErrorMessageResourceName = nameof(ValidationMessages.Required), ErrorMessageResourceType = typeof(ValidationMessages))]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
    }
}
