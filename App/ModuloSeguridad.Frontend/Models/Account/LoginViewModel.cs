using ModuloSeguridad.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Requerido),AllowEmptyStrings =false)]
        [MaxLength(50)]
        [MinLength(3)]
        [Display(Name = nameof(Usuario))]
        public string NombreUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
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
