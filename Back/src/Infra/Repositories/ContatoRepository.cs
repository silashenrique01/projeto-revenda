using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Infra.Context;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class ContatoRepository : IContatoRepository
    {

        private readonly DataContext _dataContext;

        public ContatoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IList<Contato>> GetAllContatosAsync()
        {
               return await _dataContext.Contatos.ToListAsync();
        }

        public async Task<Contato> GetContatoByIdAsync(Guid id)
        {
            return await _dataContext.Contatos.Where(c => c.Id == id).FirstOrDefaultAsync();
        }
    }
}
