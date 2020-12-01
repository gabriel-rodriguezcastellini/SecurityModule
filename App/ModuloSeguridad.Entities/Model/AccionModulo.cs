using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModuloSeguridad.Entities.Model
{
    public class AccionModulo
    {
        public int AccionModuloId { get; set; }

        public int AccionId { get; set; }

        [ForeignKey(nameof(AccionId))]
        public Accion Accion { get; set; }

        public int ModuloId { get; set; }

        [ForeignKey(nameof(ModuloId))]
        public Modulo Modulo { get; set; }

        public List<GrupoAccionModulo> GrupoAccionModulos { get; set; }
    }
}
