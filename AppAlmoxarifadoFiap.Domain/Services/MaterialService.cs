using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Domain.Interfaces.Services;

namespace AppAlmoxarifado.Domain.Services;

public class MaterialService<TContext> : BaseService<TContext, Material>, IMaterialService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IMaterialRepository<TContext> _repository;

    public MaterialService(
                        IMaterialRepository<TContext> repository,
                            IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }
}
