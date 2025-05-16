using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dtos;
using Domain;

namespace Application.Interfaces
{
    public interface IOrdemService
    {
        Task<IList<OrdemDto>> GetAllOrdens();
        Task<OrdemDto> GetOrdemById(Guid id);
        Task<OrdemDto> AddOrdem(OrdemDto ordemDto);
        Task<OrdemDto> UpdateOrdem(Guid id, OrdemDto ordemDto);
        Task<bool> DeleteOrdem(Guid id);

        Task<IList<OrdemDto>> GetOrdemByRevenda(Guid id);
    }
}
