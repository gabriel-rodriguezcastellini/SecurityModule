using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModuloSeguridad.Entities.Model
{
    public class Modulo : BaseEntity
    {
        public int ModuloId { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; }      
        
        [JsonIgnore]
        public List<AccionModulo> AccionModulos { get; set; }
    }
}
