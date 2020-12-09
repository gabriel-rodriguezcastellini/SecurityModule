using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Models.Usuarios
{
    public class UsuariosIndexViewModel : BaseViewModel
    {
        public string NombreUsuario { get; set; }

        public string ApellidoNombre { get; set; }

        public string Grupos { get; set; }

        public string Email { get; set; }

        public string Estado { get; set; }
    }
}
