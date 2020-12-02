using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModuloSeguridad.Entities.Model
{
    public class Grupo : BaseEntity
    {
        public int GrupoId { get; set; }        

        [MinLength(3)]
        [MaxLength(50)]
        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Required))]
        public string Codigo { get; set; }        

        public int EstadoGrupoId { get; set; }

        [ForeignKey(nameof(EstadoGrupoId))]
        public EstadoGrupo EstadoGrupo { get; set; }

        public List<GrupoAccionModulo> GrupoAccionModulos { get; set; }
    }
}
