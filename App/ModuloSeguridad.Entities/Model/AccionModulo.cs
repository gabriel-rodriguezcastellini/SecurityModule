using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        [JsonIgnore]
        public List<GrupoAccionModulo> GrupoAccionModulos { get; set; }
    }
}
