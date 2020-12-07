using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Frontend.Authorization;
using ModuloSeguridad.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return View(Cookie.GetUsuarioViewModel(HttpContext));
        }
    }
}
