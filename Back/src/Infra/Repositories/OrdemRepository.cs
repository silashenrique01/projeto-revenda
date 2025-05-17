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
    public class OrdemRepository : IOrdemRepository
    {
        private readonly DataContext _dataContext;
        public OrdemRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IList<Ordem>> GetAllOrdens()
        {
            IQueryable<Ordem> query = _dataContext.ordens.Include(o => o.Produtos).Include(o => o.Revenda);

            return await query.OrderBy(o => o.ClienteId).ToListAsync();
        }

        public async Task<Ordem> GetOrdemById(Guid id)
        {
            IQueryable<Ordem> query = _dataContext.ordens.Include(o => o.Produtos);

            return await query.OrderBy(o => o.ClienteId).Where(o => o.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IList<Ordem>> GetOrdemByRevenda(Guid id)
        {
            IQueryable<Ordem> query = _dataContext.ordens.Include(o => o.Produtos);

            return await query.OrderBy(o => o.ClienteId).Where(o => o.RevendaId == id).ToListAsync();
        }
    }
}
