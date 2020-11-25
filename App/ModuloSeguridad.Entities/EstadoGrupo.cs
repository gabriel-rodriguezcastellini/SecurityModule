using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class EstadoGrupo : BaseEntity
    {
        public int EstadoGrupoId { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; }

        public List<Grupo> Grupos { get; set; }
    }
}
