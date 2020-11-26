using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloSeguridad.Services
{
    public class UsuarioService : BaseService
    {
        public UsuarioService(ILogger logger, ModuloSeguridadContext context): base(logger, context)
        {
            
        }

    }
}
