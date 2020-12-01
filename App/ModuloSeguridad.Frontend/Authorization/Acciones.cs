using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Authorization
{
    public static class Acciones
    {
        public static readonly OperationAuthorizationRequirement Crear = new OperationAuthorizationRequirement { Name = Constantes.AccionCrear };
        public static readonly OperationAuthorizationRequirement Leer = new OperationAuthorizationRequirement { Name = Constantes.AccionLeer };
        public static readonly OperationAuthorizationRequirement Actualizar = new OperationAuthorizationRequirement { Name = Constantes.AccionActualizar };
        public static readonly OperationAuthorizationRequirement Eliminar = new OperationAuthorizationRequirement { Name = Constantes.AccionEliminar };
    }

    public class Constantes
    {
        public static readonly string AccionCrear = "Crear";
        public static readonly string AccionLeer = "Leer";
        public static readonly string AccionActualizar = "Actualizar";
        public static readonly string AccionEliminar = "Eliminar";
    }
}
