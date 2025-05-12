using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Threading.Tasks;
using Domain;

namespace Application.Interfaces
{
    public interface IRevendaService
    {
        Task<Revenda> AddRevenda(Revenda revenda);
        Task<Revenda> UpdateRevenda(Guid id, Revenda revenda);
        Task<bool> DeleteRevenda(Guid id);
        Task<Revenda> GetRevenda(Guid id);
        Task<IList<Revenda>> GetAllRevendas();
    }
}
