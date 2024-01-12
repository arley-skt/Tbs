using Api.ViewModel;
using AutoMapper;
using Data.Domain;

namespace Api.Mapper
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, PixOutViewModel>().ReverseMap();

            CreateMap<AccountViewModel, Produto>().ReverseMap();

            CreateMap<Produto, AccountViewModel>();

        }
    }
}
