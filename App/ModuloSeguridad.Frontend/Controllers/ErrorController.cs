using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class ErrorController : Controller
    {
        [AllowAnonymous]
        [Route(nameof(ErrorHandler))]
        public IActionResult ErrorHandler()
        {
            return RedirectToAction(nameof(Error), nameof(Error));
        }

        [AllowAnonymous]
        [Route(nameof(Error))]
        public IActionResult Error()
        {
            return View("Error");
        }

        //[Route(nameof(Forbidden))]
        //public IActionResult Forbidden()
        //{
        //    return View();
        //}
    }
}
