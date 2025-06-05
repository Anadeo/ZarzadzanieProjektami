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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfiguracja złożonego klucza głównego dla tabeli Przypisania
            modelBuilder.Entity<Przypisania>()
                .HasKey(p => new { p.id_projekt, p.id_pracownik });

            // Relacja z Projekty
            modelBuilder.Entity<Przypisania>()
                .HasOne(p => p.Projekty)
                .WithMany(p => p.Przypisania)
                .HasForeignKey(p => p.id_projekt);

            // Relacja z Pracownicy
            modelBuilder.Entity<Przypisania>()
                .HasOne(p => p.Pracownik)
                .WithMany(p => p.Przypisania)
                .HasForeignKey(p => p.id_pracownik);
        }
    }
}
