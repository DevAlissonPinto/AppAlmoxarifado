using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Domain.Interfaces.Services;
namespace AppAlmoxarifado.Domain.Services;

public class AlmoxarifadoService<TContext> : BaseService<TContext, Almoxarifado>, IAlmoxarifadoService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IAlmoxarifadoRepository<TContext> _repository;

    public AlmoxarifadoService(
                        IAlmoxarifadoRepository<TContext> repository,
                            IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }

}
