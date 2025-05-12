using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infra.Context;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly DataContext _dataContext;
        public EnderecoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IList<Endereco>> GetAllEnderecosAsync()
        {
            return await _dataContext.Enderecos.ToListAsync();
        }

        public async Task<Endereco> GetEnderecoByIdAsync(Guid id)
        {
            return await _dataContext.Enderecos.Where(e => e.Id == id).FirstOrDefaultAsync();
        }
    }
}
