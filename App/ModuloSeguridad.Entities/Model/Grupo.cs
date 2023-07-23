using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuloSeguridad.Entities.Model
{
    public class Grupo : BaseEntity
    {
        public int GrupoId { get; set; }        

        [MinLength(3)]
        [MaxLength(50)]
        [Required]
        public string Codigo { get; set; }        

        [MaxLength(100)]
        public string Descripcion { get; set; }

        public int EstadoGrupoId { get; set; }

        [ForeignKey(nameof(EstadoGrupoId))]
        public EstadoGrupo EstadoGrupo { get; set; }

        public List<GrupoAccionModulo> GrupoAccionModulos { get; set; }
    }
}
