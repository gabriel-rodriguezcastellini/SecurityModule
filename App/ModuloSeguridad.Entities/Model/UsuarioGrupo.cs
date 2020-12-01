using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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
