using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModuloSeguridad.Entities.Model
{
    public class GrupoAccionModulo
    {
        public int GrupoId { get; set; }

        [ForeignKey(nameof(GrupoId))]
        public Grupo Grupo { get; set; }

        public int AccionModuloId { get; set; }

        [ForeignKey(nameof(AccionModuloId))]
        public AccionModulo AccionModulo { get; set; }
    }
}
