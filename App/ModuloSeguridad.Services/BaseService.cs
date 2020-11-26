using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Win32.SafeHandles;
using ModuloSeguridad.Entities;
using ModuloSeguridad.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ModuloSeguridad.Services
{
    public class BaseService : IDisposable
    {
        private readonly ILogger logger;
        private readonly ModuloSeguridadContext context;
        protected readonly LogHelper logHelper;
        public BaseService(ILogger logger, ModuloSeguridadContext context)
        {
            this.logger = logger;
            this.context = context;
            logHelper = new LogHelper(logger);
        }

        // To detect redundant calls
        private bool _disposed = false;

        // Instantiate a SafeHandle instance.
        private readonly SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose() => Dispose(true);

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed state (managed objects).
                _safeHandle?.Dispose();
            }

            _disposed = true;
        }
    }
}
