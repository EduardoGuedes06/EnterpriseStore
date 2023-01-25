using EnterpriseStore.Service.Models;
using System;
using System.Threading.Tasks;

namespace EnterpriseStore.Service.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}