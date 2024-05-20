using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace AppAlmoxarifado.Infra.Repository.Repositories;

public class MaterialRepository<TContext> : BaseRepository<TContext, Material>, IMaterialRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<Material> _dbSet => ((AlmoxarifadoContext)UnitOfWork).Set<Material>();

    public MaterialRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }
}
