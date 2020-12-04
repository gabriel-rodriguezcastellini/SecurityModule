using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models
{
    public class UsuarioViewModel : BaseViewModel
    {
        [Display(Name = nameof(Usuario))]
        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Required))]
        public string NombreUsuario { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        public string Apellido { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Required))]
        [MaxLength(50)]
        [MinLength(3)]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
    }
}
