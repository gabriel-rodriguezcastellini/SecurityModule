using System.ComponentModel.DataAnnotations.Schema;

namespace ModuloSeguridad.Entities.Model
{
    public class UsuarioGrupo
    {
        public string NombreUsuario { get; set; }

        [ForeignKey(nameof(NombreUsuario))]
        public Usuario Usuario { get; set; }

        public int GrupoId { get; set; }

        [ForeignKey(nameof(GrupoId))]
        public Grupo Grupo { get; set; }
    }
}
