using System;
using System.Threading.Tasks;
using EnterpriseStore.Data.Context;
using EnterpriseStore.Service.Intefaces;
using EnterpriseStore.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace EnterpriseStore.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}