﻿using Microsoft.Extensions.Logging;
using Microsoft.Win32.SafeHandles;
using ModuloSeguridad.Entities;
using System;
using System.Runtime.InteropServices;

namespace ModuloSeguridad.Services
{
    public class BaseService : IDisposable
    {
        protected readonly ILogger logger;
        protected readonly ModuloSeguridadContext context;
        public BaseService(ILogger logger, ModuloSeguridadContext context)
        {
            this.logger = logger;
            this.context = context;
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
