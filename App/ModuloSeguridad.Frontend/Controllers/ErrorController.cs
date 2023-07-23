using Microsoft.AspNetCore.Mvc;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class ErrorController : Controller
    {
        [Route(nameof(Error))]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
