using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Models.Usuarios
{
    public class UsuariosCreateViewModel
    {
        [Required(ErrorMessageResourceName =nameof(ValidationMessages.Required), ErrorMessageResourceType =typeof(ValidationMessages))]
        [MaxLength(50, ErrorMessage = "Por favor, no escribas más de 50 caracteres.")]
        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        [Display(Name = nameof(Usuario))]
        public string NombreUsuario { get; set; }
    }
}
