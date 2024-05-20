using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces.Application.Base;

namespace AppAlmoxarifado.Domain.Interfaces.Application;

public interface IAlmoxarifadoApplication<TContext> : IBaseApplication<TContext, Almoxarifado>
where TContext : IUnitOfWork<TContext>
{

}
