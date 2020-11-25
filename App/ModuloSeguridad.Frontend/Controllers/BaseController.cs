using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected readonly ILogger<BaseController> logger;
        protected readonly ModuloSeguridadContext context;
        protected readonly LogHelper logHelper;
        public BaseController(ILogger<BaseController> logger, ModuloSeguridadContext context)
        {
            this.logger = logger;
            this.context = context;
            logHelper = new LogHelper(logger);
        }
    }
}
