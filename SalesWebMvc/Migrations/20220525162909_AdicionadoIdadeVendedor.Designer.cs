﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMvc.Data;

namespace SalesWebMvc.Migrations
{
    [DbContext(typeof(SalesWebMvcContext))]
    [Migration("20220525162909_AdicionadoIdadeVendedor")]
    partial class AdicionadoIdadeVendedor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMvc.Models.Departamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Vendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataDaVenda");

                    b.Property<int>("Status");

                    b.Property<double>("ValorDaVenda");

                    b.Property<int?>("VendedorId");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCadastroVendedor");

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<int>("DepartamentosId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<double>("SalarioBase");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentosId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Vendas", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Vendedor", "Vendedor")
                        .WithMany("VendaVendedor")
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("SalesWebMvc.Models.Vendedor", b =>
                {
                    b.HasOne("SalesWebMvc.Models.Departamentos", "Departamentos")
                        .WithMany("Vendedores")
                        .HasForeignKey("DepartamentosId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
