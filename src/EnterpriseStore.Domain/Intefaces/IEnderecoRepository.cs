using EnterpriseStore.Domain.Models;
using EnterpriseStore.Service.Models;
using System;
using System.Threading.Tasks;

namespace EnterpriseStore.Domain.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}