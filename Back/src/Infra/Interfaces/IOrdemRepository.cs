using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Infra.Interfaces
{
    public interface IOrdemRepository
    {
        Task<IList<Ordem>> GetAllOrdens();

        Task<Ordem> GetOrdemById(Guid id);
    }
}
