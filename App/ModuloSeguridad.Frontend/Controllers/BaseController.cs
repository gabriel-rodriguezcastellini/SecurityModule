using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        protected readonly ILogger<BaseController> logger;
        protected IAuthorizationService AuthorizationService { get; }
        protected string ReturnUrl { get; set; }

        [TempData]
        public string InfoMessage { get; set; }        

        public BaseController(ILogger<BaseController> logger, IAuthorizationService authorizationService)
        {
            this.logger = logger;
            AuthorizationService = authorizationService;
        }

        protected void CargarNotificacion(string mensaje)
        {
            InfoMessage = mensaje;
            TempData[nameof(InfoMessage)] = mensaje;
        }

        protected IActionResult RetornarError500(Exception exception, string actionName, string controllerName)
        {            
            logger.LogError(exception, "Ocurrió un error en action/controller {action}/{controller}", actionName, controllerName);
            CargarNotificacion("Ha ocurrido un error");
            return RedirectToAction(nameof(ErrorController.Error), "Error");
        }

        protected async Task<IActionResult> VerificarPermiso(OperationAuthorizationRequirement requirement, string modulo)
        {
            if (!(await AuthorizationService.AuthorizeAsync(User, modulo, requirement)).Succeeded) return new ForbidResult();
            return null;
        }
    }
}