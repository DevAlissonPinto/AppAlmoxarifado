using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Domain.Interfaces.Repositories;

public interface IEstoqueRepository<TContext> : IBaseRepository<TContext, Estoque>
    where TContext : IUnitOfWork<TContext>
{
}
