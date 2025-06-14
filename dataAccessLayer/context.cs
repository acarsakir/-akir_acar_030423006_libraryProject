using System;
using Microsoft.EntityFrameworkCore;
using entityLayer.concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace dataAccessLayer
{
    public class Context : IdentityDbContext<appUser, appRole, int>
    {
        // ✅ SQLite için gerekli constructor
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // ❌ Bu metodu artık siliyoruz, çünkü bağlantıyı Program.cs üzerinden veriyoruz
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        "server=localhost\\SQLEXPRESS01;initial catalog=libraryProject;integrated security=true;TrustServerCertificate=True;");
        //}

        public DbSet<kitaplar> Kitaplars { get; set; }
        public DbSet<odüncVerilenKitaplar> Odüncs { get; set; }
        public DbSet<uyeler> Uyelers { get; set; }
    }
}
