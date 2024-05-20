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

    public override async Task<Almoxarifado> SaveAsync(Almoxarifado entidade)
    {
        bool existeAlmoxarifadoNome = await ValidarAlmoxarifadoNomeExistente(entidade);
        if (existeAlmoxarifadoNome)
            throw new Exception("Já existe um almoxarifado com esse nome!");

        entidade.AtualizarDataInclusao();
        entidade.Validate();
        await _repository.SaveAsync(entidade);
        return entidade;
    }

    public override async Task<Almoxarifado> UpdateAsync(Almoxarifado entidade)
    {
        bool existeAlmoxarifadoNome = await ValidarAlmoxarifadoNomeExistente(entidade);
        if (existeAlmoxarifadoNome)
            throw new Exception("Já existe um almoxarifado com esse nome!");

        entidade.AtualizarDataAlteracao();
        entidade.Validate();
        await _repository.UpdateAsync(entidade);
        return entidade;
    }

    public async Task<bool> ValidarAlmoxarifadoNomeExistente(Almoxarifado entidade)
    {
        var almoxarifados = await _repository.GetAllAsync(x => x.Nome.Equals(entidade.Nome));
        return almoxarifados.Any(x => x.Id != entidade.Id);
    }
}
