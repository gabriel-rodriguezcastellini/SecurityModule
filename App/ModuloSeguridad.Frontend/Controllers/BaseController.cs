using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ModuloSeguridad.Frontend.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class BaseController : Controller
    {
        protected readonly ILogger<BaseController> logger;
        public BaseController(ILogger<BaseController> logger)
        {
            this.logger = logger;
        }
    }
}
