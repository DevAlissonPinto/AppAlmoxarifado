using AppAlmoxarifado.Application.Base;
using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Application;
using AppAlmoxarifado.Domain.Interfaces.Services;

namespace AppAlmoxarifado.Application;

public class AlmoxarifadoApplication<TContext> : BaseApplication<TContext, Almoxarifado>, IAlmoxarifadoApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IAlmoxarifadoService<TContext> _service;

    public AlmoxarifadoApplication(IUnitOfWork<TContext> context, IAlmoxarifadoService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }
}
