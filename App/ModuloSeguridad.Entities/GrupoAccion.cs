using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class GrupoAccion
    {
        public int GrupoId { get; set; }

        [ForeignKey(nameof(GrupoId))]
        public Grupo Grupo { get; set; }

        public int AccionId { get; set; }

        [ForeignKey(nameof(AccionId))]
        public Accion Accion { get; set; }
    }
}
