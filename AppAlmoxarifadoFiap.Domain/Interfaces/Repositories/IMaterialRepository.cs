using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Domain.Interfaces.Repositories;

public interface IMaterialRepository<TContext> : IBaseRepository<TContext, Material>
    where TContext : IUnitOfWork<TContext>
{
}
