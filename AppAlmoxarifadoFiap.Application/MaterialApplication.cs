using AppAlmoxarifado.Application.Base;
using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Application;
using AppAlmoxarifado.Domain.Interfaces.Services;

namespace AppAlmoxarifado.Application;

public class MaterialApplication<TContext> : BaseApplication<TContext, Material>, IMaterialApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IMaterialService<TContext> _service;

    public MaterialApplication(IUnitOfWork<TContext> context, IMaterialService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }
}
