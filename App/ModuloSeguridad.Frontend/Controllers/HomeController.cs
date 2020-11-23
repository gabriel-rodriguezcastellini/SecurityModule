using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Entities.Repository;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class HomeController : CommonController
    {        
        public HomeController(ILogger<HomeController> logger, UnitOfWork unitOfWork) : base(logger, unitOfWork) { }        

        public IActionResult Index()
        {
            new PruebaService(logger, unitOfWork);
            return View();
        }        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
