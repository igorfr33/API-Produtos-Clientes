﻿// <auto-generated />
using API_REST.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_REST.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("API_REST.Model.ProdutoModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Valor")
                        .HasPrecision(10, 2)
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Nome = "Caderno",
                            Valor = "7,92"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}