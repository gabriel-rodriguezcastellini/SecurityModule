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

        public BaseController(ILogger<BaseController> logger, IAuthorizationService authorizationService)
        {
            this.logger = logger;
            AuthorizationService = authorizationService;
        }

        protected string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        [TempData]
        public string InfoMessage { get; set; }
    }
}