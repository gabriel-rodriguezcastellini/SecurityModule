﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModuloSeguridad.Entities;

namespace ModuloSeguridad.Entities.Migrations
{
    [DbContext(typeof(ModuloSeguridadContext))]
    partial class ModuloSeguridadContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Accion", b =>
                {
                    b.Property<int>("AccionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActualizadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AccionId");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Acciones");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.AccionModulo", b =>
                {
                    b.Property<int>("AccionModuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccionId")
                        .HasColumnType("int");

                    b.Property<int>("ModuloId")
                        .HasColumnType("int");

                    b.HasKey("AccionModuloId");

                    b.HasIndex("AccionId");

                    b.HasIndex("ModuloId");

                    b.ToTable("AccionModulos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.EstadoGrupo", b =>
                {
                    b.Property<int>("EstadoGrupoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActualizadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EstadoGrupoId");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("EstadoGrupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.EstadoUsuario", b =>
                {
                    b.Property<int>("EstadoUsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActualizadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EstadoUsuarioId");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("EstadoUsuarios");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Grupo", b =>
                {
                    b.Property<int>("GrupoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActualizadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoGrupoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.HasKey("GrupoId");

                    b.HasIndex("Codigo")
                        .IsUnique();

                    b.HasIndex("EstadoGrupoId");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.GrupoAccionModulo", b =>
                {
                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<int>("AccionModuloId")
                        .HasColumnType("int");

                    b.HasKey("GrupoId", "AccionModuloId");

                    b.HasIndex("AccionModuloId");

                    b.ToTable("GrupoAccionModulos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Modulo", b =>
                {
                    b.Property<int>("ModuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ActualizadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ModuloId");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Modulos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Usuario", b =>
                {
                    b.Property<string>("NombreUsuario")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ActualizadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apellido")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("bit");

                    b.Property<string>("EliminadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoUsuarioId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaEliminacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NombreUsuario");

                    b.HasIndex("EstadoUsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.UsuarioGrupo", b =>
                {
                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.HasKey("NombreUsuario", "GrupoId");

                    b.HasIndex("GrupoId");

                    b.ToTable("UsuarioGrupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.AccionModulo", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Model.Accion", "Accion")
                        .WithMany("AccionModulos")
                        .HasForeignKey("AccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModuloSeguridad.Entities.Model.Modulo", "Modulo")
                        .WithMany("AccionModulos")
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accion");

                    b.Navigation("Modulo");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Grupo", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Model.EstadoGrupo", "EstadoGrupo")
                        .WithMany("Grupos")
                        .HasForeignKey("EstadoGrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoGrupo");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.GrupoAccionModulo", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Model.AccionModulo", "AccionModulo")
                        .WithMany("GrupoAccionModulos")
                        .HasForeignKey("AccionModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModuloSeguridad.Entities.Model.Grupo", "Grupo")
                        .WithMany("GrupoAccionModulos")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccionModulo");

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Usuario", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Model.EstadoUsuario", "EstadoUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("EstadoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoUsuario");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.UsuarioGrupo", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Model.Grupo", "Grupo")
                        .WithMany("UsuarioGrupos")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModuloSeguridad.Entities.Model.Usuario", "Usuario")
                        .WithMany("UsuarioGrupos")
                        .HasForeignKey("NombreUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Accion", b =>
                {
                    b.Navigation("AccionModulos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.AccionModulo", b =>
                {
                    b.Navigation("GrupoAccionModulos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.EstadoGrupo", b =>
                {
                    b.Navigation("Grupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.EstadoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Grupo", b =>
                {
                    b.Navigation("GrupoAccionModulos");

                    b.Navigation("UsuarioGrupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Modulo", b =>
                {
                    b.Navigation("AccionModulos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Model.Usuario", b =>
                {
                    b.Navigation("UsuarioGrupos");
                });
#pragma warning restore 612, 618
        }
    }
}
