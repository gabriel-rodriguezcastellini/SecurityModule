using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class ModuloSeguridadContext : DbContext
    {
        public ModuloSeguridadContext(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}