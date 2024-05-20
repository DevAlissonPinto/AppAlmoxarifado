using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace AppAlmoxarifado.Infra.Repository.Repositories;

public class AlmoxarifadoRepository<TContext> : BaseRepository<TContext, Almoxarifado>, IAlmoxarifadoRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<Almoxarifado> _dbSet => ((AlmoxarifadoContext)UnitOfWork).Set<Almoxarifado>();

    public AlmoxarifadoRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }

}
