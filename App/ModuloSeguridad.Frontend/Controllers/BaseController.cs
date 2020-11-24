using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ILogger<BaseController> logger;
        protected readonly ModuloSeguridadContext context;
        public BaseController(ILogger<BaseController> logger, ModuloSeguridadContext context)
        {
            this.logger = logger;
            this.context = context;
        }
    }
}
