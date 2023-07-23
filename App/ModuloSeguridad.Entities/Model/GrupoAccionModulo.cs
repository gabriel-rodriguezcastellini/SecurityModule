using System.ComponentModel.DataAnnotations.Schema;

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
