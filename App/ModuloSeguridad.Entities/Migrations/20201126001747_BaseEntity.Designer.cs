﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModuloSeguridad.Entities;

namespace ModuloSeguridad.Entities.Migrations
{
    [DbContext(typeof(ModuloSeguridadContext))]
    [Migration("20201126001747_BaseEntity")]
    partial class BaseEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ModuloSeguridad.Entities.Accion", b =>
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

                    b.Property<int>("FormularioId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AccionId");

                    b.HasIndex("FormularioId");

                    b.ToTable("Acciones");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.EstadoGrupo", b =>
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

                    b.ToTable("EstadoGrupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.EstadoUsuario", b =>
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

                    b.ToTable("EstadoUsuarios");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Formulario", b =>
                {
                    b.Property<int>("FormularioId")
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

                    b.Property<int>("ModuloId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FormularioId");

                    b.HasIndex("ModuloId");

                    b.ToTable("Formularios");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Grupo", b =>
                {
                    b.Property<int>("GrupoId")
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

                    b.Property<int>("EstadoGrupoId")
                        .HasColumnType("int");

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

                    b.HasKey("GrupoId");

                    b.HasIndex("EstadoGrupoId");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.GrupoAccion", b =>
                {
                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<int>("AccionId")
                        .HasColumnType("int");

                    b.HasKey("GrupoId", "AccionId");

                    b.HasIndex("AccionId");

                    b.ToTable("GrupoAcciones");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Modulo", b =>
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

                    b.Property<int?>("ModuloPadreId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ModuloId");

                    b.HasIndex("ModuloPadreId");

                    b.ToTable("Modulos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Usuario", b =>
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

            modelBuilder.Entity("ModuloSeguridad.Entities.UsuarioGrupo", b =>
                {
                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.HasKey("NombreUsuario", "GrupoId");

                    b.HasIndex("GrupoId");

                    b.ToTable("UsuarioGrupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Accion", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Formulario", "Formulario")
                        .WithMany("Acciones")
                        .HasForeignKey("FormularioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Formulario");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Formulario", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Modulo", "Modulo")
                        .WithMany("Formularios")
                        .HasForeignKey("ModuloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modulo");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Grupo", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.EstadoGrupo", "EstadoGrupo")
                        .WithMany("Grupos")
                        .HasForeignKey("EstadoGrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoGrupo");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.GrupoAccion", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Accion", "Accion")
                        .WithMany("GrupoAcciones")
                        .HasForeignKey("AccionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModuloSeguridad.Entities.Grupo", "Grupo")
                        .WithMany("GrupoAcciones")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accion");

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Modulo", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Modulo", "ModuloPadre")
                        .WithMany("ModulosHijos")
                        .HasForeignKey("ModuloPadreId");

                    b.Navigation("ModuloPadre");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Usuario", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.EstadoUsuario", "EstadoUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("EstadoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoUsuario");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.UsuarioGrupo", b =>
                {
                    b.HasOne("ModuloSeguridad.Entities.Grupo", "Grupo")
                        .WithMany("UsuarioGrupos")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModuloSeguridad.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioGrupos")
                        .HasForeignKey("NombreUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grupo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Accion", b =>
                {
                    b.Navigation("GrupoAcciones");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.EstadoGrupo", b =>
                {
                    b.Navigation("Grupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.EstadoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Formulario", b =>
                {
                    b.Navigation("Acciones");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Grupo", b =>
                {
                    b.Navigation("GrupoAcciones");

                    b.Navigation("UsuarioGrupos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Modulo", b =>
                {
                    b.Navigation("Formularios");

                    b.Navigation("ModulosHijos");
                });

            modelBuilder.Entity("ModuloSeguridad.Entities.Usuario", b =>
                {
                    b.Navigation("UsuarioGrupos");
                });
#pragma warning restore 612, 618
        }
    }
}
