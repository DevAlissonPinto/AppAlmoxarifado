using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Domain.Interfaces.Services;

public interface IMaterialService<TContext> : IBaseService<TContext, Material> where TContext : IUnitOfWork<TContext>
{
}
