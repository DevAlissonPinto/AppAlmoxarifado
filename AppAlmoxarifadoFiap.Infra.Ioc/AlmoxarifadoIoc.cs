using AppAlmoxarifado.Application;
using AppAlmoxarifado.Application.Base;
using AppAlmoxarifado.Domain.Interfaces;
using AppAlmoxarifado.Domain.Interfaces.Application;
using AppAlmoxarifado.Domain.Interfaces.Application.Base;
using AppAlmoxarifado.Domain.Interfaces.Repositories;
using AppAlmoxarifado.Domain.Services;
using AppAlmoxarifado.Infra.Repository.Context;
using AppAlmoxarifado.Infra.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AppAlmoxarifado.Domain.Interfaces.Services;

namespace AppAlmoxarifado.Infra.Ioc;

public static class AlmoxarifadoIoc
{
    public static void Initialize(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<AlmoxarifadoContext>(options => options.UseSqlServer(configuration.GetConnectionString("AlmoxarifadoConnection")));
        services.AddScoped<IUnitOfWork<AlmoxarifadoContext>, AlmoxarifadoContext>();

        services.AddScoped(typeof(IBaseApplication<,>), typeof(BaseApplication<,>));
        services.AddScoped(typeof(IBaseService<,>), typeof(BaseService<,>));
        services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));

        services.AddScoped(typeof(IAlmoxarifadoApplication<>), typeof(AlmoxarifadoApplication<>));
        services.AddScoped(typeof(IAlmoxarifadoService<>), typeof(AlmoxarifadoService<>));
        services.AddScoped(typeof(IAlmoxarifadoRepository<>), typeof(AlmoxarifadoRepository<>));

        services.AddScoped(typeof(IMaterialApplication<>), typeof(MaterialApplication<>));
        services.AddScoped(typeof(IMaterialService<>), typeof(MaterialService<>));
        services.AddScoped(typeof(IMaterialRepository<>), typeof(MaterialRepository<>));
    }

}
