using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Domain.Interfaces.Repositories;

public interface IMovimentacaoEstoqueRepository<TContext> : IBaseRepository<TContext, MovimentacaoEstoque>
    where TContext : IUnitOfWork<TContext>
{
}
