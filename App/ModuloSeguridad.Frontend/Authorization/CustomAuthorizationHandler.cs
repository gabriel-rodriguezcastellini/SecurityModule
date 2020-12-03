using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Authorization
{
    public class CustomAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, UsuarioViewModel>
    {
        UsuarioService usuarioService;

        public CustomAuthorizationHandler(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            OperationAuthorizationRequirement requirement,
            UsuarioViewModel usuario)
        {            
            if (context.User == null || usuario == null)
            {
                return Task.CompletedTask;
            }

            // If not asking for approval/reject, return.
            if (requirement.Name != Constantes.AccionCrear &&
                requirement.Name != Constantes.AccionLeer)
            {
                return Task.CompletedTask;
            }
            else
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
