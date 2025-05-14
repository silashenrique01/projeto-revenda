using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dtos;

namespace Application.Interfaces
{
    public interface IOrdemService
    {
        Task<IList<OrdemDto>> GetAllOrdens();
        Task<OrdemDto> GetOrdemById(Guid id);
        Task<OrdemDto> AddOrdem(OrdemDto ordemDto);
        Task<OrdemDto> UpdateOrdem(Guid id, OrdemDto ordemDto);
        Task<bool> DeleteOrdem(Guid id);
    }
}
