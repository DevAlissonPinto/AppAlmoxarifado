using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Infra.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace AppAlmoxarifado.Infra.Repository.Repositories;

public class MovimentacaoEstoqueRepository<TContext> : BaseRepository<TContext, MovimentacaoEstoque>, IMovimentacaoEstoqueRepository<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private DbSet<MovimentacaoEstoque> _dbSet => ((AlmoxarifadoContext)UnitOfWork).Set<MovimentacaoEstoque>();

    public MovimentacaoEstoqueRepository(IUnitOfWork<TContext> unitOfWork) : base(unitOfWork) { }
}
