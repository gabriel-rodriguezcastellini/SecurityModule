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

        public async Task Agregar(Grupo grupo, string nombreUsuario)
        {
            context.NombreUsuario = nombreUsuario;
            await context.Grupos.AddAsync(grupo);
            await context.SaveChangesAsync();
        }

        public async Task<bool> GrupoExiste(string codigo)
        {
            return await context.Grupos.AnyAsync(g => g.Codigo == codigo);
        }
    }
}
