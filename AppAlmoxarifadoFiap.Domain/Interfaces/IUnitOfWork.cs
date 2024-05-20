namespace AppAlmoxarifado.Domain.Interfaces;

public interface IUnitOfWork<TContext>
{
    int Commit();
}
