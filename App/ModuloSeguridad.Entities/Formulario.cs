using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class Formulario : BaseEntity
    {
        public int FormularioId { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Nombre { get; set; }

        public List<Accion> Acciones { get; set; }

        public int ModuloId { get; set; }

        [ForeignKey(nameof(ModuloId))]
        public Modulo Modulo { get; set; }
    }
}
