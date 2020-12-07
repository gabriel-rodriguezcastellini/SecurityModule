using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Frontend.Authorization;

namespace ModuloSeguridad.Frontend.Controllers
{
    [AutoValidateAntiforgeryToken]    
    public class BaseController : Controller
    {
        protected readonly ILogger<BaseController> logger;
        protected IAuthorizationService AuthorizationService { get; }
        protected string ReturnUrl { get; set; }

        [TempData]
        public string InfoMessage { get; set; }

        [TempData]
        public string ColorMessage { get; set; }

        [TempData]
        public string SymbolMessage { get; set; }

        public BaseController(ILogger<BaseController> logger, IAuthorizationService authorizationService)
        {
            this.logger = logger;
            AuthorizationService = authorizationService;
        }

        protected void CargarNotificacion(string mensaje, string color, string simbolo)
        {
            InfoMessage = mensaje;
            ColorMessage = color;
            SymbolMessage = simbolo;
        }
    }
}