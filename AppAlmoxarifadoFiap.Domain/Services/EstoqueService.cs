using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Domain.Interfaces.Services;
namespace AppAlmoxarifado.Domain.Services;

public class EstoqueService<TContext> : BaseService<TContext, Estoque>, IEstoqueService<TContext>
    where TContext : IUnitOfWork<TContext>
{
    private readonly IEstoqueRepository<TContext> _repository;

    public EstoqueService(
                        IEstoqueRepository<TContext> repository,
                            IUnitOfWork<TContext> unitOfWork) : base(repository, unitOfWork)
    {
        _repository = repository;
    }

    public override async Task<Estoque> SaveAsync(Estoque entidade)
    {
        bool existeAlmoxarifadoNome = await ValidarEstoqueNomeExistente(entidade);
        if (existeAlmoxarifadoNome)
            throw new Exception("Já existe um almoxarifado com esse nome!");

        entidade.AtualizarDataInclusao();
        entidade.Validate();
        await _repository.SaveAsync(entidade);
        return entidade;
    }

    public override async Task<Estoque> UpdateAsync(Estoque entidade)
    {
        bool existeAlmoxarifadoNome = await ValidarEstoqueNomeExistente(entidade);
        if (existeAlmoxarifadoNome)
            throw new Exception("Já existe um almoxarifado com esse nome!");

        entidade.AtualizarDataAlteracao();
        entidade.Validate();
        await _repository.UpdateAsync(entidade);
        return entidade;
    }

    public async Task<bool> ValidarEstoqueNomeExistente(Estoque entidade)
    {
        var almoxarifados = await _repository.GetAllAsync(x => x.Nome.Equals(entidade.Nome));
        return almoxarifados.Any(x => x.Id != entidade.Id);
    }
}
