using Microsoft.EntityFrameworkCore;
using ProjektProgramowanieObiektowe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjektProgramowanieObiektowe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pracownicy> Pracownicy { get; set; }
        public DbSet<Projekty> Projekty { get; set; }
        public DbSet<Przypisania> Przypisania { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    Console.WriteLine("OnModelCreating called");
        //    foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        //    {
        //        Console.WriteLine(entityType.Name);
        //    }
        //}

        // (opcjonalnie) konfiguracje modeli przez Fluent API
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
