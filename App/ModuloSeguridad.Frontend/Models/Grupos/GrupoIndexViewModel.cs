using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static ModuloSeguridad.Services.Common.Enums;

namespace ModuloSeguridad.Frontend.Models.Grupos
{
    public class GrupoIndexViewModel
    {
        public string Descripcion { get; set; }
        
        public EstadoGrupos Estado { get; set; }

        public List<Grupo> Grupos { get; set; }

        public class Grupo
        {
            public int GrupoId { get; set; }
            public string Codigo { get; set; }            
            public string Descripcion { get; set; }
            public string Estado { get; set; }
        }
    }
}
