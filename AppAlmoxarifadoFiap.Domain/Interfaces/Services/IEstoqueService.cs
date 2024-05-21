using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Domain.Interfaces.Services;

public interface IEstoqueService<TContext> : IBaseService<TContext, Estoque> 
    where TContext : IUnitOfWork<TContext>
{
    Task<bool> ValidarEstoqueNomeExistente(Estoque entidade);
}
