using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Infra.Interfaces
{
    public interface IRevendaRepository
    {
        Task<Revenda> GetRevendaByIdAsync(Guid id);
        Task<IList<Revenda>> GetAllRevendasAsync();
    }
}
