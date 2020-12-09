using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ModuloSeguridad.Frontend.Controllers
{
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
