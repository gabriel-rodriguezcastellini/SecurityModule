using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Logging
{
    public static class LogHelper
    {
        private static readonly string asterisks = "*".PadLeft(10, '*');        

        public static void InicioMetodo(this ILogger logger, [CallerMemberName] string methodName = "")
        {
            logger.LogInformation(string.Format(string.Concat(asterisks, " ", methodName, " Inicio ", asterisks)));
        }

        public static void FinMetodo(this ILogger logger, [CallerMemberName] string methodName = "")
        {
            logger.LogInformation(string.Format(string.Concat(asterisks, " ", methodName, " Fin ", asterisks)));
        }
    }
}
