﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Frontend.Authorization;
using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    [AutoValidateAntiforgeryToken]
    [Authorize]
    public class BaseController : Controller
    {
        protected readonly ILogger<BaseController> logger;
        protected IAuthorizationService AuthorizationService { get; }
        protected string ReturnUrl { get; set; }

        [TempData]
        public string InfoMessage { get; set; }

        [TempData]
        public string ColorMessage { get; set; }

        [TempData]
        public string SymbolMessage { get; set; }

        public BaseController(ILogger<BaseController> logger, IAuthorizationService authorizationService)
        {
            this.logger = logger;
            AuthorizationService = authorizationService;
        }

        protected void CargarNotificacion(string mensaje, string color, string simbolo)
        {
            InfoMessage = mensaje;
            ColorMessage = color;
            SymbolMessage = simbolo;
        }

        protected IActionResult RetornarError500(Exception exception, string methodName)
        {
            logger.LogError(exception, "Ocurrió un error en " + methodName);
            CargarNotificacion("Ha ocurrido un error", "danger-color", "fas fa-exclamation");
            return RedirectToAction(nameof(ErrorController.Error), "Error");
        }

        protected async Task<IActionResult> VerificarPermiso(OperationAuthorizationRequirement requirement, string modulo)
        {
            if (!(await AuthorizationService.AuthorizeAsync(User, modulo, requirement)).Succeeded) return new ForbidResult();
            return null;
        }
    }
}