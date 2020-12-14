using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Services;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models.Usuarios
{
    public class UsuarioLoginViewModel
    {
        [Display(Name = nameof(Usuario))]
        [Required(ErrorMessageResourceType =typeof(ValidationMessages), ErrorMessageResourceName = nameof(ValidationMessages.Required))]
        public string NombreUsuario { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = nameof(ValidationMessages.Required))]
        public string Clave { get; set; }
    }
}