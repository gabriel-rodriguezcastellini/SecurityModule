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
            var nombreUsuario = context.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            logger.LogInformation("El usuario {usuario} quiere entrar al módulo {modulo} para realizar la acción {accion}", 
                nombreUsuario, requirement.Modulo, requirement.Accion);
            using (usuarioService)
            {
                if(usuarioService.TienePermisoAccionModulo(context.User?.FindFirstValue(ClaimTypes.NameIdentifier), requirement.Accion, requirement.Modulo)) context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
