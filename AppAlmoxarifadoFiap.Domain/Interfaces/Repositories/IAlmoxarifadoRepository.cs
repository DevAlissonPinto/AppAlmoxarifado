using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Domain.Interfaces.Repositories;

public interface IAlmoxarifadoRepository<TContext> : IBaseRepository<TContext, Almoxarifado>
    where TContext : IUnitOfWork<TContext>
{
}
