using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dtos;
using Application.Interfaces;
using AutoMapper;
using Domain;
using Infra.Interfaces;

namespace Application.Services
{
    public class RevendaService : IRevendaService
    {
        private readonly IRevendaRepository _revendaRepository;
        private readonly IAbstractRepository _abstractRepository;
        private readonly IMapper _mapper;

        public RevendaService(IRevendaRepository revendaRepository, IAbstractRepository abstractRepository, IMapper mapper)
        {
            _revendaRepository = revendaRepository;
            _abstractRepository = abstractRepository;
            _mapper = mapper;
        }

        

        public async Task<RevendaDto> AddRevenda(RevendaDto revenda)
        {
            try
            {
                var revendaMapped = _mapper.Map<Revenda>(revenda);

                _abstractRepository.Add<Revenda>(revendaMapped);
                if (await _abstractRepository.SaveChangesAsync())
                {
                    var result = await _revendaRepository.GetRevendaByIdAsync(revendaMapped.Id);
                    return _mapper.Map<RevendaDto>(result);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteRevenda(Guid id)
        {
            try
            {
                var result = await _revendaRepository.GetRevendaByIdAsync(id);
                if (result == null) throw new Exception("Não encontrado");

                _abstractRepository.Delete<Revenda>(result);

                return await _abstractRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<RevendaDto>> GetAllRevendas()
        {
            try
            {
                var result = await _revendaRepository.GetAllRevendasAsync();

                if (result == null) return null;

                var revendas = _mapper.Map<IList<RevendaDto>>(result);

                return revendas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<RevendaDto> GetRevenda(Guid id)
        {
            try
            {
                var result = await _revendaRepository.GetRevendaByIdAsync(id);
                if (result == null) return null;
                
                var revenda = _mapper.Map<RevendaDto>(result);
                
                return revenda;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<RevendaDto> UpdateRevenda(Guid id, RevendaDto revenda)
        {
            try
            {
                var revendaResult = await _revendaRepository.GetRevendaByIdAsync(id);
                if (revendaResult == null) return null;

                revenda.Id = revendaResult.Id;

                _mapper.Map(revenda, revendaResult);

                _abstractRepository.Update<Revenda>(revendaResult);

                if (await _abstractRepository.SaveChangesAsync())
                {
                    var result = await _revendaRepository.GetRevendaByIdAsync(revendaResult.Id);
                    return _mapper.Map<RevendaDto>(result);
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
