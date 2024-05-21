using AppAlmoxarifado.Domain.Entities;
using AutoMapper;

namespace AppAlmoxarifado.Web.MappingProfile;

public class MovimentacaoEstoqueMapper : Profile
{
    public MovimentacaoEstoqueMapper()
    {
        CreateMap<MovimentacaoEstoqueViewModel, MovimentacaoEstoque>().ReverseMap();
    }
}
