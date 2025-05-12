using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Infra.Interfaces
{
    public interface IEnderecoRepository
    {       
        Task<Endereco> GetEnderecoByIdAsync(Guid id);
        Task<IList<Endereco>> GetAllEnderecosAsync();

    }
}
