using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Application.Interfaces
{
    public interface IContatoService
    {
        Task<Contato> AddContato(Contato contato);
        Task<Contato> UpdateContato(Guid id, Contato contato);
        Task<bool> DeleteContato(Guid id);
        Task<IList<Contato>> GetAllContatos();
        Task<Contato> GetContatatoById(Guid id);
    }
}
