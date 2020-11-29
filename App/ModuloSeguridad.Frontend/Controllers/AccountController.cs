using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Frontend.Models.Account;
using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UsuarioService usuarioService;
        public AccountController(ILogger<AccountController> logger, UsuarioService usuarioService) : base(logger)
        {
            this.usuarioService = usuarioService;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
