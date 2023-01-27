using EnterpriseStore.Domain.Models;
using EnterpriseStore.Service.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnterpriseStore.Domain.Intefaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}