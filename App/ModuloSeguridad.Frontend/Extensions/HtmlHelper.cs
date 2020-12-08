using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloSeguridad.Frontend.Extensions
{
    public static class HtmlHelper
    {
        public static string Active(this IHtmlHelper htmlHelper, string controllerName)
        {
            var data = htmlHelper.ViewContext.HttpContext.GetEndpoint().Metadata.GetMetadata<ControllerActionDescriptor>();
            return data.ControllerName == controllerName ? "active" : null;
        }
    }
}
