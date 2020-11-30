using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }
        }

        protected string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }
    }
}
