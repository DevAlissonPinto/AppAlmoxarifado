using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace AppAlmoxarifado.Infra.Repository.Repositories;

public class EstoqueRepository<TContext> : BaseRepository<TContext, Estoque>, IEstoqueRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<Estoque> _dbSet => ((AlmoxarifadoContext)UnitOfWork).Set<Estoque>();

    public EstoqueRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }

}
