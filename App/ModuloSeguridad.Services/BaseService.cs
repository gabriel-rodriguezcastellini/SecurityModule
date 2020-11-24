using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloSeguridad.Services
{
    public class BaseService
    {
        protected readonly ILogger logger;
        protected readonly ModuloSeguridadContext context;
        public BaseService(ILogger logger, ModuloSeguridadContext context)
        {
            this.logger = logger;
            this.context = context;
        }
    }
}
