using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger<HomeController> logger, IAuthorizationService authorizationService) : base(logger, authorizationService)
        {
            
        }

        public IActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    return RedirectToAction(nameof(ErrorController.Error403), nameof(ErrorController.Error));
            //}
            return View(new UsuarioViewModel());
        }
    }
}
