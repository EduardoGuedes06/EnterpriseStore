using AutoMapper;
using EnterpriseStore.API.ViewModel;
using EnterpriseStore.API.ViewModels;
using EnterpriseStore.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseStore.API.Configuration
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
