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
    public class RevendaRepository : IRevendaRepository
    {
        private readonly DataContext _dataContext;
        public RevendaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IList<Revenda>> GetAllRevendasAsync()
        {
            IQueryable<Revenda> query = _dataContext.Revendas.Include(r => r.Enderecos).Include(r => r.Contatos);

            return await query.OrderBy(r => r.RazaoSocial).ToListAsync();
        }

        public async Task<Revenda> GetRevendaByIdAsync(Guid id)
        {
            IQueryable<Revenda> query = _dataContext.Revendas.Include(r => r.Enderecos).Include(r => r.Contatos);

            return await query.OrderBy(r => r.RazaoSocial).Where(r => r.Id == id).FirstOrDefaultAsync();
        }  
    }
}
