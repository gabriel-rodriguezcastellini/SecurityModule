using Microsoft.AspNetCore.Authorization;
using ModuloSeguridad.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Authorization
{
    public class UserRequirement : IAuthorizationRequirement
    {
        public UserRequirement()
        {
            
        }
    }
}
