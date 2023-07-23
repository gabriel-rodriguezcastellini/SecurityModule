using Microsoft.AspNetCore.Authorization;

namespace ModuloSeguridad.Frontend.Authorization
{
    internal class AccionModuloRequirement : IAuthorizationRequirement
    {
        public string Accion { get; private set; }

        public string Modulo { get; private set; }

        public AccionModuloRequirement(string accion, string modulo) 
        {
            Accion = accion;
            Modulo = modulo; 
        }
    }
}
