using API_REST.Model;
using EntityFrameworkCore.EncryptColumn;
using EntityFrameworkCore.EncryptColumn.Extension;
using EntityFrameworkCore.EncryptColumn.Interfaces;
using EntityFrameworkCore.EncryptColumn.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Services.WebApi.Jwt;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API_REST.Data
{
    public class AppDbContext : DbContext
    {

        private readonly IEncryptionProvider provider;

        public  AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            Initialize.EncryptionKey = "example_encrypt_key_key1";
            this.provider = new GenerateEncryptionProvider();
           
        }

        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseEncryption(this.provider);
            modelBuilder.HasDefaultSchema("produtosdb");
            modelBuilder.Entity<ProdutoModel>().Property(p => p.Nome).HasMaxLength(80);
            modelBuilder.Entity<ProdutoModel>().Property(p => p.Valor).HasPrecision(10 ,2);
        }
    }
    }


