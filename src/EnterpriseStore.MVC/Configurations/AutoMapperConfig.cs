using AutoMapper;
using EnterpriseStore.Domain.Models;
using EnterpriseStore.MVC.ViewModels;
using EnterpriseStore.Service.Models;

namespace EnterpriseStore.MVC.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}