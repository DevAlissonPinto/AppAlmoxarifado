using AppAlmoxarifado.Domain.Entities;
using AppAlmoxarifado.Web.Models;
using AutoMapper;

namespace AppAlmoxarifado.Web.MappingProfile;

public class MaterialMapper : Profile
{
    public MaterialMapper()
    {
        CreateMap<MaterialViewModel, Material>();
        CreateMap<Material, MaterialViewModel>();
    }
}
