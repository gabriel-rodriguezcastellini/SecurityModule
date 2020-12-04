using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using ModuloSeguridad.Services;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Authorization
{
    public class UserAuthorizationHandler : AuthorizationHandler<UserRequirement>
    {
        private readonly UsuarioService usuarioService;

        public UserAuthorizationHandler(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            UserRequirement requirement)
        {
            ControllerActionDescriptor controllerActionDescriptor;
            AuthorizationFilterContext authorizationFilterContext;

            if (context.Resource is HttpContext httpContext)
            {
                controllerActionDescriptor = httpContext.GetEndpoint().Metadata.GetMetadata<ControllerActionDescriptor>();
                authorizationFilterContext = httpContext.GetEndpoint().Metadata.GetMetadata<AuthorizationFilterContext>();
            }
            else
            {
                return Task.CompletedTask;
            }

            //if (!context.User.HasClaim(c => c.Type == ClaimTypes.DateOfBirth &&
            //                            c.Issuer == "http://contoso.com"))
            //{
            //    return Task.CompletedTask;
            //}

            //var dateOfBirth = Convert.ToDateTime(
            //    context.User.FindFirst(c => c.Type == ClaimTypes.DateOfBirth &&
            //                                c.Issuer == "http://contoso.com").Value);

            //int calculatedAge = DateTime.Today.Year - dateOfBirth.Year;
            //if (dateOfBirth > DateTime.Today.AddYears(-calculatedAge))
            //{
            //    calculatedAge--;
            //}

            //if (calculatedAge >= -1)
            //{
            //    context.Succeed(requirement);
            //}

            context.Succeed(requirement);

            return Task.CompletedTask;



            ////var endpoint = context.Resource as RouteEndpoint;
            ////var descriptor = endpoint?.Metadata?
            ////    .SingleOrDefault(md => md is ControllerActionDescriptor) as ControllerActionDescriptor;

            ////if (descriptor == null)
            ////    throw new InvalidOperationException("Unable to retrieve current action descriptor.");

            ////var controllerName = descriptor.ControllerName;
            ////var actionName = descriptor.ActionName;

            //var mvcContext = context.Resource as AuthorizationFilterContext;
            //var descriptor = mvcContext?.ActionDescriptor as ControllerActionDescriptor;

            //if (descriptor != null)
            //{
            //    var actionName = descriptor.ActionName;
            //    var ctrlName = descriptor.ControllerName;
            //}

            //if (context.User == null)
            //{

            //    return Task.CompletedTask;
            //}

            //if (context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value != usuario.NombreUsuario)
            //{
            //    return Task.CompletedTask;
            //}            
        }        
    }
}
