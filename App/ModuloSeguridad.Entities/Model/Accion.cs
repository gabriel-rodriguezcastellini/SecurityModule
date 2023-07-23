using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Entities.Model
{
    public class Accion : BaseEntity
    {
        public int AccionId { get; set; }

        [MaxLength(50)]
        [MinLength(3)]
        [Required]
        public string Nombre { get; set; }        
        
        [JsonIgnore]
        public List<AccionModulo> AccionModulos { get; set; }
    }
}
