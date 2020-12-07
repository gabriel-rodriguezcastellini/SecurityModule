using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using ModuloSeguridad.Entities.Model;
using ModuloSeguridad.Frontend.Models;
using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Authorization
{
    public class AccionAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, UsuarioViewModel>
    {
        private readonly UsuarioService usuarioService;

        public AccionAuthorizationHandler(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, UsuarioViewModel resource)
        {
            if (context.User == null || resource == null) return Task.CompletedTask;
            if (requirement.Name != resource.AccionModuloActual.Accion.Nombre) return Task.CompletedTask;
            using (usuarioService)
            {
                if (usuarioService.TienePermisoAccion(resource.NombreUsuario, requirement.Name, resource.AccionModuloActual.Modulo.Nombre)) context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }

    public static class Acciones
    {
        public static readonly OperationAuthorizationRequirement Leer = new OperationAuthorizationRequirement { Name = nameof(Leer) };
        public static readonly OperationAuthorizationRequirement Crear = new OperationAuthorizationRequirement { Name = nameof(Crear) };
        public static readonly OperationAuthorizationRequirement Actualizar = new OperationAuthorizationRequirement { Name = nameof(Actualizar) };
        public static readonly OperationAuthorizationRequirement Eliminar = new OperationAuthorizationRequirement { Name = nameof(Eliminar) };
        public static readonly OperationAuthorizationRequirement ResetearClave = new OperationAuthorizationRequirement { Name = nameof(ResetearClave) };
    }
}
