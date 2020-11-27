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

        [MinLength(3)]
        [MaxLength(50)]
        [Required(ErrorMessageResourceType = typeof(Validaciones), ErrorMessageResourceName = nameof(Validaciones.Requerido))]
        public string Codigo { get; set; }

        [MinLength(3)]
        [MaxLength(50)]
        public string Descripcion { get; set; }

        public int EstadoGrupoId { get; set; }

        [ForeignKey(nameof(EstadoGrupoId))]
        public EstadoGrupo EstadoGrupo { get; set; }

        public List<UsuarioGrupo> UsuarioGrupos { get; set; }

        public List<GrupoAccion> GrupoAcciones { get; set; }
    }
}
