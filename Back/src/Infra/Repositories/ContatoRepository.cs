using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Infra.Interfaces;

namespace Infra.Repositories
{
    public class ContatoRepository : IAbstractRepository, IContatoRepository
    {
        public Task<IList<Contato>> GetAllContatosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Contato> GetContatoByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        void IAbstractRepository.Add<T>(T entity)
        {
            throw new NotImplementedException();
        }

        void IAbstractRepository.Delete<T>(T entity)
        {
            throw new NotImplementedException();
        }

        void IAbstractRepository.DeleteRange<T>(T[] entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IAbstractRepository.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        void IAbstractRepository.Update<T>(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
