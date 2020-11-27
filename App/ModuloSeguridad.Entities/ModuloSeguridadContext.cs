using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class ModuloSeguridadContext : DbContext
    {
        public ModuloSeguridadContext(DbContextOptions options) : base(options) { }

        public DbSet<Accion> Acciones { get; set; }
        public DbSet<EstadoGrupo> EstadoGrupos { get; set; }
        public DbSet<EstadoUsuario> EstadoUsuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<GrupoAccion> GrupoAcciones { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }                                
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accion>()
                .HasIndex(a => a.Nombre)
                .IsUnique();

            modelBuilder.Entity<EstadoGrupo>()
                .HasIndex(eg => eg.Nombre)
                .IsUnique();

            modelBuilder.Entity<EstadoUsuario>()
                .HasIndex(eu => eu.Nombre)
                .IsUnique();            

            modelBuilder.Entity<Grupo>()
                .HasIndex(g => g.Codigo)
                .IsUnique();

            modelBuilder.Entity<GrupoAccion>()
                .HasKey(ga => new { ga.GrupoId, ga.AccionId });

            modelBuilder.Entity<GrupoAccion>()
                .HasOne(ga => ga.Grupo)
                .WithMany(g => g.GrupoAcciones)
                .HasForeignKey(ga => ga.GrupoId);

            modelBuilder.Entity<GrupoAccion>()
                .HasOne(ga => ga.Accion)
                .WithMany(a => a.GrupoAcciones)
                .HasForeignKey(ga => ga.AccionId);            

            modelBuilder.Entity<Modulo>()
                .HasIndex(m => m.Nombre)
                .IsUnique();

            modelBuilder.Entity<UsuarioGrupo>()
                .HasKey(ug => new { ug.NombreUsuario, ug.GrupoId });

            modelBuilder.Entity<UsuarioGrupo>()
                .HasOne(ug => ug.Usuario)
                .WithMany(u => u.UsuarioGrupos)
                .HasForeignKey(ug => ug.NombreUsuario);

            modelBuilder.Entity<UsuarioGrupo>()
                .HasOne(ug => ug.Grupo)
                .WithMany(g => g.UsuarioGrupos)
                .HasForeignKey(ug => ug.GrupoId);            
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            foreach (var item in ChangeTracker.Entries().Where(t=>t.State == EntityState.Added).Select(t=>t.Entity).ToArray())
            {
                if (item is BaseEntity)
                {
                    (item as BaseEntity).FechaCreacion = DateTime.Now;
                }
            }

            foreach (var item in ChangeTracker.Entries().Where(t => t.State == EntityState.Modified).Select(t => t.Entity).ToArray())
            {
                if (item is BaseEntity)
                {
                    (item as BaseEntity).FechaActualizacion = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}