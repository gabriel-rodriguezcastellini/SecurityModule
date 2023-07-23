using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System.Threading.Tasks;

namespace ModuloSeguridad.Services
{
    public class EstadoGrupoService : BaseService
    {
        public EstadoGrupoService(ILogger logger, ModuloSeguridadContext context) : base(logger, context) { }

        public async Task<EstadoGrupo> GetEstadoGrupoAsync(string nombre)
        {
            return await context.EstadoGrupos.FirstOrDefaultAsync(eg => eg.Nombre == nombre);
        }
    }
}
