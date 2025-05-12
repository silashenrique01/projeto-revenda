using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Application.Interfaces
{
    public interface IEnderecoService
    {
        Task<Endereco> AddEndereco(Endereco endereco);
        Task<Endereco> UpdateEndereco(Guid id, Endereco endereco);
        Task<bool> DeleteEndereco(Guid id);
        Task<Endereco> GetEndereco(Guid id);
        Task<IList<Endereco>> GetAllEnderecos();
    }
}
