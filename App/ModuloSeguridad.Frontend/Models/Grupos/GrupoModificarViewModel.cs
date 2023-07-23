using ModuloSeguridad.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models.Grupos
{
    public class GrupoModificarViewModel
    {
        public int GrupoId { get; set; }

        [MinLength(3, ErrorMessage = "Por favor, no escribas menos de 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Por favor, no escribas más de 50 caracteres.")]
        [Required(ErrorMessageResourceName = nameof(ValidationMessages.Required), ErrorMessageResourceType = typeof(ValidationMessages))]
        public string Codigo { get; set; }

        [MaxLength(100, ErrorMessage = "Por favor, no escribas más de 100 caracteres.")]
        public string Descripcion { get; set; }

        [Display(Name = "Estado")]
        public bool Activo { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public List<AccionModulos> Modulos { get; set; }

        public class Usuario
        {
            public string NombreUsuario { get; set; }
            public string NombreApellido { get; set; }
            public bool Checked { get; set; }
        }

        public class AccionModulos
        {
            public int ModuloId { get; set; }
            public string ModuloNombre { get; set; }
            public bool Checked { get; set; }
            public List<Accion> Acciones { get; set; }
        }

        public class Accion
        {
            public int AccionId { get; set; }
            public string AccionNombre { get; set; }
            public bool Checked { get; set; }
        }
    }
}
