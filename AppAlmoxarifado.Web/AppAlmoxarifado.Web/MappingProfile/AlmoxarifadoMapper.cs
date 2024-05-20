using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Web.Models;
using AutoMapper;

namespace AppAlmoxarifado.Web.MappingProfile;

public class AlmoxarifadoMapper : Profile
{
    public AlmoxarifadoMapper()
    {
        CreateMap<AlmoxarifadoViewModel, Almoxarifado>();
        CreateMap<Almoxarifado, AlmoxarifadoViewModel>();
    }
}
