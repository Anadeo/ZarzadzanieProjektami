using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProjektProgramowanieObiektowe.Data;

// Fabryka kontekstu używana podczas operacji projektowych (np. migracji).
// Dzięki niej Entity Framework Core wie, jak utworzyć DbContext,
// nawet gdy aplikacja nie korzysta z ASP.NET Core (np. Windows Forms).
public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    // Metoda wywoływana przez EF Core w czasie projektowym (design-time),
    // np. podczas wykonywania poleceń migracji.
    public AppDbContext CreateDbContext(string[] args)
    {
        // Tworzenie konfiguracji na podstawie pliku appsettings.json.
        // Directory.GetCurrentDirectory() zapewnia poprawną ścieżkę podczas działania z CLI.
        //var configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();                                    // Zbudowanie obiektu konfiguracji

        // Tworzymy obiekt opcji dla DbContext na podstawie connection stringa.
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        //var connectionString = configuration.GetConnectionString("DefaultConnection");
        var connectionString = "Data source=..\\..\\..\\db.db";
        //var connectionString = "Server=localhost;Database=projekty;User=root;Password=;";
        //ServerVersion.AutoDetect(connectionString)
            optionsBuilder.UseSqlite(connectionString);

            return new AppDbContext(optionsBuilder.Options);
    }
}