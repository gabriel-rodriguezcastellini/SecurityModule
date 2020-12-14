using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Frontend.Models
{
    public class UsuarioViewModel
    {
        public class AccionModulo
        {
            public string Accion { get; set; }
            public string Modulo { get; set; }
        }
    }
}
