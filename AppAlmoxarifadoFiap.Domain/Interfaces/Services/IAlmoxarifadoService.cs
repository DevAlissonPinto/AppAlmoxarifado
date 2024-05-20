using AppAlmoxarifado.Domain.Entities;

namespace AppAlmoxarifado.Domain.Interfaces.Services;

public interface IAlmoxarifadoService<TContext> : IBaseService<TContext, Almoxarifado> where TContext : IUnitOfWork<TContext>
{
}
