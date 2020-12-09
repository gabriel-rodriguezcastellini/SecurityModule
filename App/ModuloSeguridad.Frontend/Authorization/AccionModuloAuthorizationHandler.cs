using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Authorization
{
    internal class AccionModuloAuthorizationHandler : AuthorizationHandler<AccionModuloRequirement>
    {
        private readonly ILogger<AccionModuloAuthorizationHandler> logger;
        private readonly UsuarioService usuarioService;

        public AccionModuloAuthorizationHandler(ILogger<AccionModuloAuthorizationHandler> logger, UsuarioService usuarioService)
        {
            this.logger = logger;
            this.usuarioService = usuarioService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AccionModuloRequirement requirement)
        {
            logger.InicioMetodo("HandleRequirementAsync");
            logger.LogInformation("Módulo: {modulo}", requirement.Modulo);
            logger.LogInformation("Acción: {accion}", requirement.Accion);
            var nombreUsuario = context.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            logger.LogInformation("nombreUsuario: {usuario}", nombreUsuario);
            using (usuarioService)
            {
                if (string.IsNullOrEmpty(requirement.Accion))
                {
                    if (usuarioService.TienePermisoModulo(context.User?.FindFirstValue(ClaimTypes.NameIdentifier), requirement.Modulo)) context.Succeed(requirement);
                }
                else if (usuarioService.TienePermisoAccionModulo(context.User?.FindFirstValue(ClaimTypes.NameIdentifier), requirement.Accion, requirement.Modulo)) context.Succeed(requirement);
            }
            logger.FinMetodo("HandleRequirementAsync");
            return Task.CompletedTask;
        }
    }
}
