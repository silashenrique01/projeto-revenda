using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Infra.Interfaces
{
    public interface IContatoRepository
    {
        Task<Contato> GetContatoByIdAsync(Guid id);
        Task<IList<Contato>> GetAllContatosAsync();
    }
}
