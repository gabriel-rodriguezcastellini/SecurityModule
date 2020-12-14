using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSeguridad.Services
{    
    public class EstadoUsuarioService : BaseService
    {
        public EstadoUsuarioService(ILogger logger, ModuloSeguridadContext context) : base(logger, context) { }

        public async Task<EstadoUsuario> GetEstadoUsuarioAsync(string nombre)
        {
            return await context.EstadoUsuarios.FirstOrDefaultAsync(eu => eu.Nombre == nombre);
        }
    }
}
