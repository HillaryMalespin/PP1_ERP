﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PP2_ERP.Data;

#nullable disable

namespace PP2_ERP.Migrations
{
    [DbContext(typeof(ApplicationDbContent))]
    [Migration("20240920072320_Migracion1")]
    partial class Migracion1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PP2_ERP.Modelos.Articulo", b =>
                {
                    b.Property<int>("Codigo_Articulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo_Articulo"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<float>("Costo")
                        .HasColumnType("real");

                    b.Property<string>("Nombre_Articulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<float>("Precio_Estandar")
                        .HasColumnType("real");

                    b.HasKey("Codigo_Articulo");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Bodega", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"));

                    b.Property<float>("Capacidad_Toneladas")
                        .HasColumnType("real");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo");

                    b.ToTable("Bodega");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Caso", b =>
                {
                    b.Property<int>("Codigo_Caso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo_Caso"));

                    b.Property<string>("Cedula_Cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cliente_Contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Apertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Cierre")
                        .HasColumnType("datetime2");

                    b.Property<string>("Prioridad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_Caso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo_Caso");

                    b.ToTable("Caso");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Cliente", b =>
                {
                    b.Property<int>("Cedula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cedula"));

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cedula");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Cotizacion", b =>
                {
                    b.Property<int>("Codigo_Cotizacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo_Cotizacion"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Cierre")
                        .HasColumnType("datetime2");

                    b.Property<float>("Monto_Total")
                        .HasColumnType("real");

                    b.Property<float>("Probabilidad")
                        .HasColumnType("real");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_Cotizacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zona")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo_Cotizacion");

                    b.ToTable("Cotizacion");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Factura", b =>
                {
                    b.Property<int>("Numero_Factura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numero_Factura"));

                    b.Property<string>("Cedula_Cliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula_Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre_Local")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vendedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Numero_Factura");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Familia", b =>
                {
                    b.Property<int>("Codigo_Familia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo_Familia"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Familia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Codigo_Familia");

                    b.ToTable("Familia");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.HistoricoPuesto", b =>
                {
                    b.Property<int>("Cedula_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cedula_Usuario"));

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cedula_Usuario");

                    b.ToTable("HistoricoPuesto");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.HistoricoSalario", b =>
                {
                    b.Property<int>("Cedula_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cedula_Usuario"));

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Inicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salario")
                        .HasColumnType("real");

                    b.HasKey("Cedula_Usuario");

                    b.ToTable("HistoricoSalario");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Inventario", b =>
                {
                    b.Property<int>("Codigo_Articulo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo_Articulo"));

                    b.Property<int>("Cantidad_Disponible")
                        .HasColumnType("int");

                    b.Property<int>("Codigo_Bodega")
                        .HasColumnType("int");

                    b.HasKey("Codigo_Articulo");

                    b.ToTable("Inventario");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.MovimientoInventario", b =>
                {
                    b.Property<int>("IdMovimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMovimiento"));

                    b.Property<int>("Bodega_Destino")
                        .HasColumnType("int");

                    b.Property<int>("Bodega_Origen")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Codigo_Articulo")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMovimiento");

                    b.ToTable("MovimientoInventario");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Planilla", b =>
                {
                    b.Property<int>("Cedula_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cedula_Usuario"));

                    b.Property<int>("Horas_Extras")
                        .HasColumnType("int");

                    b.Property<int>("Horas_Trabajadas")
                        .HasColumnType("int");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<float>("Salario_Pagado")
                        .HasColumnType("real");

                    b.HasKey("Cedula_Usuario");

                    b.ToTable("Planilla");
                });

            modelBuilder.Entity("PP2_ERP.Modelos.Usuario", b =>
                {
                    b.Property<int>("Cedula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cedula"));

                    b.Property<string>("Departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_ingreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Puesto")
                        .HasColumnType("real");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cedula");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
