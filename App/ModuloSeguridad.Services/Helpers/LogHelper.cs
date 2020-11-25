using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ModuloSeguridad.Services.Helpers
{
    public class LogHelper
    {
        private readonly ILogger logger;
        private static readonly string asterisks = "*".PadLeft(10, '*');

        public LogHelper(ILogger logger)
        {
            this.logger = logger;
        }

        public void InicioMetodo([CallerMemberName] string methodName = "")
        {
            logger.LogInformation(string.Format(string.Concat(asterisks.PadRight(1,' '), methodName, " Inicio ", asterisks)));
        }

        public void FinMetodo([CallerMemberName] string methodName = "")
        {
            logger.LogInformation(string.Format(string.Concat(asterisks.PadRight(1, ' '), methodName, " Fin ", asterisks)));
        }
    }
}
