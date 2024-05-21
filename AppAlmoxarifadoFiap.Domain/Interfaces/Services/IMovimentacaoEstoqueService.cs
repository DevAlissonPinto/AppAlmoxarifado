using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Domain.Interfaces.Services;

public interface IMovimentacaoEstoqueService<TContext> : IBaseService<TContext, MovimentacaoEstoque> where TContext : IUnitOfWork<TContext>
{
}

