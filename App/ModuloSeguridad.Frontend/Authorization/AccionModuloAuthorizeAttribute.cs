using Microsoft.AspNetCore.Authorization;

namespace ModuloSeguridad.Frontend.Authorization
{
    internal class AccionModuloAuthorizeAttribute : AuthorizeAttribute
    {
        const string POLICY_PREFIX = "AccionModulo";

        public AccionModuloAuthorizeAttribute(string accion, string modulo) 
        {
            Accion = accion;
            Modulo = modulo;
            Policy = $"{POLICY_PREFIX}{accion}_{modulo}";
        }

        public string Accion { get; set; }

        public string Modulo { get; set; }

        //public string Accion
        //{
        //    get
        //    {
        //        return Policy[POLICY_PREFIX.Length..];
        //    }
        //    set
        //    {
        //        Policy = $"{POLICY_PREFIX}{value}";
        //    }
        //}

        //public string Modulo
        //{
        //    get
        //    {
        //        return Policy[POLICY_PREFIX.Length..];
        //    }
        //    set
        //    {
        //        Policy = $"{POLICY_PREFIX}{value}";
        //    }
        //}
    }
}
