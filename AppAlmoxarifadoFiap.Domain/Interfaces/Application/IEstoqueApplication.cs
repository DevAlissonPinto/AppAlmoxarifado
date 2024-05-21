using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces.Application.Base;

namespace AppAlmoxarifado.Domain.Interfaces.Application;

public interface IEstoqueApplication<TContext> : IBaseApplication<TContext, Estoque>
where TContext : IUnitOfWork<TContext>
{

}
