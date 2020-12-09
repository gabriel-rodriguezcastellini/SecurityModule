using Microsoft.EntityFrameworkCore;
using ModuloSeguridad.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuloSeguridad.Entities
{
    public class ModuloSeguridadContext : DbContext
    {
        public ModuloSeguridadContext(DbContextOptions options) : base(options) { }

        public string NombreUsuario { get; set; }

        public DbSet<Accion> Acciones { get; set; }
        public DbSet<AccionModulo> AccionModulos { get; set; }
        public DbSet<EstadoGrupo> EstadoGrupos { get; set; }
        public DbSet<EstadoUsuario> EstadoUsuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<GrupoAccionModulo> GrupoAccionModulos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }                                
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accion>()
                .HasIndex(a => a.Nombre)
                .IsUnique();

            modelBuilder.Entity<AccionModulo>()
                .HasOne(am => am.Accion)
                .WithMany(am => am.AccionModulos)
                .HasForeignKey(am => am.AccionId);

            modelBuilder.Entity<AccionModulo>()
                .HasOne(am => am.Modulo)
                .WithMany(am => am.AccionModulos)
                .HasForeignKey(am => am.ModuloId);

            modelBuilder.Entity<EstadoGrupo>()
                .HasIndex(eg => eg.Nombre)
                .IsUnique();

            modelBuilder.Entity<EstadoUsuario>()
                .HasIndex(eu => eu.Nombre)
                .IsUnique();

            modelBuilder.Entity<Grupo>()
                .HasIndex(g => g.Codigo)
                .IsUnique();

            modelBuilder.Entity<GrupoAccionModulo>()
                .HasKey(gam => new { gam.GrupoId, gam.AccionModuloId });

            modelBuilder.Entity<GrupoAccionModulo>()
                .HasOne(gam => gam.Grupo)
                .WithMany(gam => gam.GrupoAccionModulos)
                .HasForeignKey(gam => gam.GrupoId);

            modelBuilder.Entity<GrupoAccionModulo>()
                .HasOne(gam => gam.AccionModulo)
                .WithMany(gam => gam.GrupoAccionModulos)
                .HasForeignKey(gam => gam.AccionModuloId);

            modelBuilder.Entity<Modulo>()
                .HasIndex(m => m.Nombre)
                .IsUnique();            

            modelBuilder.Entity<UsuarioGrupo>()
                .HasKey(ug => new { ug.NombreUsuario, ug.GrupoId });

            modelBuilder.Entity<UsuarioGrupo>()
                .HasOne(ug => ug.Usuario)
                .WithMany(u => u.UsuarioGrupos)
                .HasForeignKey(ug => ug.NombreUsuario);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            foreach (var item in ChangeTracker.Entries().Where(t=>t.State == EntityState.Added).Select(t=>t.Entity).ToArray())
            {
                if (item is BaseEntity)
                {
                    (item as BaseEntity).FechaCreacion = DateTime.Now;
                    (item as BaseEntity).CreadoPor = NombreUsuario;
                }
            }

            foreach (var item in ChangeTracker.Entries().Where(t => t.State == EntityState.Modified).Select(t => t.Entity).ToArray())
            {
                if (item is BaseEntity)
                {
                    (item as BaseEntity).FechaActualizacion = DateTime.Now;
                    (item as BaseEntity).ActualizadoPor = NombreUsuario;
                }
            }

            return base.SaveChanges();
        }
    }
}