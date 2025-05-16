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
    public class OrdemService : IOrdemService
    {

        private readonly IOrdemRepository _ordemRepository;
        private readonly IAbstractRepository _abstractRepository;
        private readonly IMapper _mapper;

        public OrdemService(IOrdemRepository ordemRepository, IAbstractRepository abstractRepository, IMapper mapper)
        {
            _abstractRepository = abstractRepository;
            _ordemRepository = ordemRepository;
            _mapper = mapper; 
        }

        public async Task<OrdemDto> AddOrdem(OrdemDto ordemDto)
        {
            try
            {
                var ordemMapped = _mapper.Map<Ordem>(ordemDto);

                _abstractRepository.Add<Ordem>(ordemMapped);
                if (await _abstractRepository.SaveChangesAsync())
                {
                    var result = await _ordemRepository.GetOrdemById(ordemMapped.Id);
                    return _mapper.Map<OrdemDto>(result);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteOrdem(Guid id)
        {
            try
            {
                var result = await _ordemRepository.GetOrdemById(id);
                if (result == null) throw new Exception("Não encontrado");

                _abstractRepository.Delete<Ordem>(result);

                return await _abstractRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<OrdemDto>> GetAllOrdens()
        {
            try
            {
                var result = await _ordemRepository.GetAllOrdens();

                if (result == null || result.Count == 0) throw new Exception("Nenhum objeto encontrado");

                var ordens = _mapper.Map<IList<OrdemDto>>(result);

                return ordens;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<OrdemDto> GetOrdemById(Guid id)
        {
            try
            {
                var result = await _ordemRepository.GetOrdemById(id);
                if (result == null) throw new Exception("Nenhum objeto encontrado");

                var ordem = _mapper.Map<OrdemDto>(result);

                return ordem;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IList<OrdemDto>> GetOrdemByRevenda(Guid id)
        {
            try
            {
                var result = await _ordemRepository.GetOrdemByRevenda(id);
                if (result == null) throw new Exception("Nenhum objeto encontrado");

                var ordem = _mapper.Map<IList<OrdemDto>>(result);

                return ordem;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<OrdemDto> UpdateOrdem(Guid id, OrdemDto ordemDto)
        {
            try
            {
                var ordemResult = await _ordemRepository.GetOrdemById(id);
                if (ordemResult == null) throw new Exception("Nenhum objeto encontrado");

                ordemDto.Id = ordemResult.Id;

                _mapper.Map(ordemDto, ordemResult);

                _abstractRepository.Update<Ordem>(ordemResult);

                if (await _abstractRepository.SaveChangesAsync())
                {
                    var result = await _ordemRepository.GetOrdemById(ordemResult.Id);
                    return _mapper.Map<OrdemDto>(result);
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
