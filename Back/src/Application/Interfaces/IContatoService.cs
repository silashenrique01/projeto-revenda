using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dtos;
using Domain;

namespace Application.Interfaces
{
    public interface IContatoService
    {
        Task<ContatoDto> AddContato(ContatoDto contato);
        Task<ContatoDto> UpdateContato(Guid id, ContatoDto contato);
        Task<bool> DeleteContato(Guid id);
        Task<IList<ContatoDto>> GetAllContatos();
        Task<ContatoDto> GetContatatoById(Guid id);
    }
}
