using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Domain.Interfaces.Services;

namespace AppAlmoxarifado.Domain.Services;

public class MovimentacaoEstoqueService<TContext> : BaseService<TContext, MovimentacaoEstoque>, IMovimentacaoEstoqueService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IMovimentacaoEstoqueRepository<TContext> _repository;

    public MovimentacaoEstoqueService(
                IMovimentacaoEstoqueRepository<TContext> repository,
                    IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }

}
