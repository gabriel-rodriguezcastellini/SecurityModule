using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger<HomeController> logger, ModuloSeguridadContext context) : base(logger, context) 
        { 

        }        

        public IActionResult Index()
        {
            return View();
        }        
        
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
