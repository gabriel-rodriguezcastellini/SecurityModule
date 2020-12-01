using ModuloSeguridad.Entities.Model;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models.Account
{
    public class AccountLoginViewModel
    {
        [Display(Name = nameof(Usuario))]
        public string NombreUsuario { get; set; }
        
        [DataType(DataType.Password)]
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
