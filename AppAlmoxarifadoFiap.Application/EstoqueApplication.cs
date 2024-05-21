using AppAlmoxarifado.Application.Base;
using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Application;
using AppAlmoxarifado.Domain.Interfaces.Services;

namespace AppAlmoxarifado.Application;

public class EstoqueApplication<TContext> : BaseApplication<TContext, Estoque>, IEstoqueApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IEstoqueService<TContext> _service;

    public EstoqueApplication(IUnitOfWork<TContext> context, IEstoqueService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }

    public override async Task<Estoque> SaveAsync(Estoque entity)
    {
        await _service.SaveAsync(entity);
        _unitOfWork.Commit();

        return entity;
    }

    public override async Task<Estoque> UpdateAsync(Estoque entity)
    {
        await _service.UpdateAsync(entity);
        _unitOfWork.Commit();

        return entity;
    }
}
