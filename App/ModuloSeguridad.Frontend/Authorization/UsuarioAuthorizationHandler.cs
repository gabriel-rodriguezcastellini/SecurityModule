using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using ModuloSeguridad.Services;
using System.Security.Claims;
using System.Threading.Tasks;
using static ModuloSeguridad.Frontend.Authorization.UsuarioAuthorizationHandler;

namespace ModuloSeguridad.Frontend.Authorization
{
    public class UsuarioAuthorizationHandler : AuthorizationHandler<UsuarioRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            UsuarioRequirement requirement)
        {
            if (context.User == null || context.User?.HasClaim(c=>c.Type == ClaimTypes.NameIdentifier) == false) return Task.CompletedTask;
            context.Succeed(requirement);
            return Task.CompletedTask;
        }

        public class UsuarioRequirement : IAuthorizationRequirement { }
    }
}
