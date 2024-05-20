using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces.Application.Base;

namespace AppAlmoxarifado.Domain.Interfaces.Application;

public interface IMaterialApplication<TContext> : IBaseApplication<TContext, Material>
where TContext : IUnitOfWork<TContext>
{

}
