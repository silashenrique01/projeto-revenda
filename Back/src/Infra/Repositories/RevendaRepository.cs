using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infra.Context;
using Infra.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;

namespace Infra.Repositories
{
    public class RevendaRepository : IRevendaRepository, IAbstractRepository
    {
        private readonly DataContext _dataContext;
        public RevendaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Add<T>(T entity) where T : class
        {
            _dataContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _dataContext.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _dataContext.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _dataContext.SaveChangesAsync()) > 0;
        }

        public Task<IList<Revenda>> GetAllRevendasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Revenda> GetRevendaByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
