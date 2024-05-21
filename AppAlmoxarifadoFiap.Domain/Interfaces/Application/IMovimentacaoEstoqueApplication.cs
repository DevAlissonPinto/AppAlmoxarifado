using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces.Application.Base;

namespace AppAlmoxarifado.Domain.Interfaces.Application;

public interface IMovimentacaoEstoqueApplication<TContext> : IBaseApplication<TContext, MovimentacaoEstoque>
where TContext : IUnitOfWork<TContext>
{

}
