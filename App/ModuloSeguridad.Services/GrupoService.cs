using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ModuloSeguridad.Services.Common.Enums;

namespace ModuloSeguridad.Services
{
    public class GrupoService : BaseService
    {
        public GrupoService(ILogger logger, ModuloSeguridadContext context) : base(logger, context) { }

        public async Task<IQueryable<Grupo>> GetGruposAsync(string descripcion = null, EstadoGrupos estado = EstadoGrupos.Todos)
        {
            var grupos = (await context.Grupos.OrderBy(g => g.Codigo).Include(g => g.EstadoGrupo).ToListAsync()).AsQueryable();
            if (!string.IsNullOrEmpty(descripcion))
            {
                descripcion = descripcion.Trim().ToLower();
                grupos = grupos.Where(g => g.Descripcion.ToLower().Contains(descripcion));
            }
            if (estado != EstadoGrupos.Todos) grupos = grupos.Where(u => u.EstadoGrupo.Nombre == estado.ToString());
            return grupos.AsQueryable();
        }

        public async Task<int> Agregar(Grupo grupo, string nombreUsuario)
        {
            context.NombreUsuario = nombreUsuario;
            await context.Grupos.AddAsync(grupo);
            await context.SaveChangesAsync();
            return grupo.GrupoId;
        }

        public async Task<bool> GrupoExiste(string codigo)
        {
            return await context.Grupos.AnyAsync(g => g.Codigo == codigo);
        }

        public async Task Eliminar(int grupoId, string nombreUsuario)
        {
            context.NombreUsuario = nombreUsuario;
            context.Grupos.Remove(await context.Grupos.FindAsync(grupoId));
            await context.SaveChangesAsync();
        }

        public async Task<bool> GrupoTieneUsuarios(int grupoId)
        {
            return await context.UsuarioGrupos.AnyAsync(ug => ug.GrupoId == grupoId);
        }

        public async Task<Grupo> GetGrupoAsync(int grupoId)
        {
            return await context.Grupos.OrderBy(g => g.GrupoId == grupoId)
                .Include(e=>e.EstadoGrupo)
                .Include(u => u.GrupoAccionModulos).FirstOrDefaultAsync(g => g.GrupoId == grupoId);
        }

        public async Task Modificar(Grupo grupo, string nombreUsuario)
        {
            context.NombreUsuario = nombreUsuario;
            context.Grupos.Update(grupo);
            await context.SaveChangesAsync();
        }
    }
}
