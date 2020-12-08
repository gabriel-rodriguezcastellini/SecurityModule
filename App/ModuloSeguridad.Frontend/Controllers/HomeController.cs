using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Frontend.Authorization;

namespace ModuloSeguridad.Frontend.Controllers
{
    [Authorize(nameof(UsuarioAuthorizationHandler))]
    public class HomeController : BaseController
    {
        public HomeController(ILogger<HomeController> logger, IAuthorizationService authorizationService) : base(logger, authorizationService)
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
