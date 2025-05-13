using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dtos;

namespace Application.Interfaces
{
    public interface IRevendaService
    {
        Task<RevendaDto> AddRevenda(RevendaDto revenda);
        Task<RevendaDto> UpdateRevenda(Guid id, RevendaDto revenda);
        Task<bool> DeleteRevenda(Guid id);
        Task<RevendaDto> GetRevenda(Guid id);
        Task<IList<RevendaDto>> GetAllRevendas();
    }
}
