using AppAlmoxarifado.Application.Base;
using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Application;
using AppAlmoxarifado.Domain.Interfaces.Services;

namespace AppAlmoxarifado.Application;

public class MovimentacaoEstoqueApplication<TContext> : BaseApplication<TContext, MovimentacaoEstoque>, IMovimentacaoEstoqueApplication<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IMovimentacaoEstoqueService<TContext> _service;

    public MovimentacaoEstoqueApplication(IUnitOfWork<TContext> context, IMovimentacaoEstoqueService<TContext> service)
        : base(context, service)
    {
        _service = service;
    }

}