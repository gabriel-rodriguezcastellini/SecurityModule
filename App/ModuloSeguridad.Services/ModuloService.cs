using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Services
{
    public class ModuloService : BaseService
    {
        public ModuloService(ILogger logger, ModuloSeguridadContext context) : base(logger, context) { }

        public async Task<IQueryable<Modulo>> ModulosAsync()
        {
            return (await context.Modulos.Include(am=>am.AccionModulos).ThenInclude(gam=>gam.GrupoAccionModulos)
                .Include(am => am.AccionModulos)
                .ThenInclude(a=>a.Accion).ToListAsync()).AsQueryable();
        }

        public async Task<AccionModulo> GetAccionModuloAsync(int accionId, int moduloId)
        {
            return await context.AccionModulos.FirstOrDefaultAsync(a => a.AccionId == accionId && a.ModuloId == moduloId);
        }
    }
}
