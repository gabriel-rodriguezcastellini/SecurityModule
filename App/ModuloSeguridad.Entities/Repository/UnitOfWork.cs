using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloSeguridad.Entities.Repository
{
    public class UnitOfWork : IDisposable
    {
        private readonly ModuloSeguridadContext context;
        private GenericRepository<Usuario> usuarioRepository;

        public UnitOfWork(ModuloSeguridadContext context)
        {
            this.context = context;
        }

        public GenericRepository<Usuario> UsuarioRepository
        {
            get
            {
                if (usuarioRepository == null) usuarioRepository = new GenericRepository<Usuario>(context);
                return usuarioRepository;
            }
        }

        public void Guardar()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
