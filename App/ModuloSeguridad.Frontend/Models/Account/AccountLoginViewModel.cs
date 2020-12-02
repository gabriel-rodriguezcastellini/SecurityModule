using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models.Account
{
    public class AccountLoginViewModel : BaseViewModel
    {
        [Display(Name = nameof(Usuario))]
        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Required))]
        public string NombreUsuario { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Required))]
        public string Clave { get; set; }

        public Usuario ConvertirUsuario()
        {
            return new Usuario()
            {
                NombreUsuario = NombreUsuario,
                Clave = Clave
            };
        }
    }
}
