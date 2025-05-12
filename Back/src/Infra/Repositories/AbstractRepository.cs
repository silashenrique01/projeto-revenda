using System.Threading.Tasks;
using Infra.Context;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class AbstractRepository : IAbstractRepository
    {

        private readonly DataContext _dataContext;

        public AbstractRepository(DataContext dataContext)
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

        public void Update<T>(T entity) where T : class
        {
           _dataContext.Update(entity);
        }
    }
}
