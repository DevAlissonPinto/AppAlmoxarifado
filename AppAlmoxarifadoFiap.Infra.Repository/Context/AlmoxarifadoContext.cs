using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Infra.Repository.Maps;
using Microsoft.EntityFrameworkCore;
using Regulacao.Repository.Maps;

namespace AppAlmoxarifado.Infra.Repository.Context;

public class AlmoxarifadoContext : DbContext, IUnitOfWork<AlmoxarifadoContext>
{
    public AlmoxarifadoContext(DbContextOptions<AlmoxarifadoContext> options) : base(options) { }

    public int Commit() => this.SaveChanges();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.ApplyConfiguration(new AlmoxarifadoMap());
        //modelBuilder.ApplyConfiguration(new MaterialMap());

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AlmoxarifadoContext).Assembly);

    }
}
