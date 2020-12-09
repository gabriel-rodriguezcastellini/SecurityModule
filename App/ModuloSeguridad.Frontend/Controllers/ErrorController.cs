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
        [Route(nameof(Error))]
        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
