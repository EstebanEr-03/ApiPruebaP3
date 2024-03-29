﻿// <auto-generated />
using System;
using API_PRUEBA_PROGRESO3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_PRUEBA_PROGRESO3.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_PRUEBA_PROGRESO3.Models.Resultado", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<int>("CantidadVictorias")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaResultado")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("resultado")
                        .HasColumnType("bit");

                    b.HasKey("idUsuario");

                    b.ToTable("Resultados");
                });

            modelBuilder.Entity("API_PRUEBA_PROGRESO3.Models.Tarea", b =>
                {
                    b.Property<int>("idTarea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTarea"));

                    b.Property<string>("descripcionTarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoTarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreTarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTarea");

                    b.ToTable("Tarea");

                    b.HasData(
                        new
                        {
                            idTarea = 1,
                            descripcionTarea = "20 ejercicios",
                            estadoTarea = "Pendiente",
                            nombreTarea = "Matematicas"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
