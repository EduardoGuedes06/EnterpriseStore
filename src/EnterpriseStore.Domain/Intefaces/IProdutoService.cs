

using EnterpriseStore.Domain.Models;
using EnterpriseStore.Service.Models;

namespace EnterpriseStore.Domain.Intefaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}