using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ModuloSeguridad.Services.Common.Enums;

namespace ModuloSeguridad.Frontend.Models.Usuarios
{
    public class UsuariosIndexViewModel : BaseViewModel
    {
        public string ApellidoNombre { get; set; }        

        public EstadoUsuarios? Estado { get; set; }

        public int GrupoId { get; set; }

        public List<SelectListItem> Grupos { get; set; }

        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public class Usuario
        {
            public string NombreUsuario { get; set; }

            public string ApellidoNombre { get; set; }

            public string Grupos { get; set; }

            public string Email { get; set; }

            public string Estado { get; set; }
        }
    }
}
