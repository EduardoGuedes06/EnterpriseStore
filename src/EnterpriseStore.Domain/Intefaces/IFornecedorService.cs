
using EnterpriseStore.Domain.Models;
using EnterpriseStore.Service.Models;
using System;
using System.Threading.Tasks;

namespace EnterpriseStore.Domain.Intefaces
{
    public interface IFornecedorService : IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}