using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Microsoft.Extensions.Logging
{
    public static class LogHelper
    {
        private static readonly string asterisks = "*".PadLeft(10, '*');        

        public static void InicioMetodo(this ILogger logger, [CallerMemberName] string methodName = "")
        {
            logger.LogInformation(string.Format(string.Concat(asterisks.PadRight(1,' '), methodName, " Inicio ", asterisks)));
        }

        public static void FinMetodo(this ILogger logger, [CallerMemberName] string methodName = "")
        {
            logger.LogInformation(string.Format(string.Concat(asterisks.PadRight(1, ' '), methodName, " Fin ", asterisks)));
        }
    }
}
