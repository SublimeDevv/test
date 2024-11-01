﻿// <auto-generated />
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241003004208_M3")]
    partial class M3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Estudiantes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Domain.Entities.jugador", b =>
                {
                    b.Property<int>("pkJugador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pkJugador"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("posicion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pkJugador");

                    b.ToTable("jugador");
                });

            modelBuilder.Entity("Domain.Entities.logs", b =>
                {
                    b.Property<int>("idLog")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idLog"), 1L, 1);

                    b.Property<string>("Datos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomFuncion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusLog")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mensaje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idLog");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Domain.Entities.persona", b =>
                {
                    b.Property<int>("PkPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkPersona"), 1L, 1);

                    b.Property<string>("CancionFav")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorFav")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComidaFav")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkPersona");

                    b.ToTable("Persona");
                });
#pragma warning restore 612, 618
        }
    }
}
