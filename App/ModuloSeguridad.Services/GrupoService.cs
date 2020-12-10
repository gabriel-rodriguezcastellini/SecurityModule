using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Services
{
    public class GrupoService : BaseService
    {
        public GrupoService(ILogger logger, ModuloSeguridadContext context) : base(logger, context)
        {

        }

        public async Task<List<Grupo>> GetGruposAsync()
        {
            return await context.Grupos.OrderBy(g=>g.Codigo).ToListAsync();
        }
    }
}
