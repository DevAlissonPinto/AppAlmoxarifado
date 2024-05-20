using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AppAlmoxarifado.Infra.Repository.Context;

public class AlmoxarifadoContextFactory : IDesignTimeDbContextFactory<AlmoxarifadoContext>
{
    public AlmoxarifadoContext CreateDbContext(string[] args)
    {
        var configPath = args.Length > 0 ? args[0] : Directory.GetCurrentDirectory();
        var configuration = new ConfigurationBuilder()
            .SetBasePath(configPath)
            .AddJsonFile("appsettings.json")
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<AlmoxarifadoContext>();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("AlmoxarifadoConnection"));

        return new AlmoxarifadoContext(optionsBuilder.Options);
    }
}
