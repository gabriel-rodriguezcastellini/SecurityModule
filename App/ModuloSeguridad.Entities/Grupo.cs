using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class Grupo : BaseEntity
    {
        public int GrupoId { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; }

        public int EstadoGrupoId { get; set; }

        [ForeignKey(nameof(EstadoGrupoId))]
        public EstadoGrupo EstadoGrupo { get; set; }

        public List<UsuarioGrupo> UsuarioGrupos { get; set; }

        public List<GrupoAccion> GrupoAcciones { get; set; }
    }
}
