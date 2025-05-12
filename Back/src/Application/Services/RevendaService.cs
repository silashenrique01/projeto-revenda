using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain;
using Infra.Interfaces;

namespace Application.Services
{
    public class RevendaService : IRevendaService
    {
        private readonly IRevendaRepository _revendaRepository;
        private readonly IAbstractRepository _abstractRepository;

        public RevendaService(IRevendaRepository revendaRepository, IAbstractRepository abstractRepository)
        {
            _revendaRepository = revendaRepository;
            _abstractRepository = abstractRepository;
        }
        public async Task<Revenda> AddRevenda(Revenda revenda)
        {
            try
            {
                _abstractRepository.Add<Revenda>(revenda);
                if (await _abstractRepository.SaveChangesAsync())
                {
                    return await _revendaRepository.GetRevendaByIdAsync(revenda.Id);
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

        public async Task<IList<Revenda>> GetAllRevendas()
        {
            try
            {
                var result = await _revendaRepository.GetAllRevendasAsync();

                if (result == null) return null;

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Revenda> GetRevenda(Guid id)
        {
            try
            {
                var result = await _revendaRepository.GetRevendaByIdAsync(id);
                if (result == null) return null;
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<Revenda> UpdateRevenda(Guid id, Revenda revenda)
        {
            try
            {
                var result = await _revendaRepository.GetRevendaByIdAsync(id);
                if (result == null) return null;

                revenda.update(id);

                _abstractRepository.Update<Revenda>(revenda);

                if (await _abstractRepository.SaveChangesAsync())
                {
                    return await _revendaRepository.GetRevendaByIdAsync(id);
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
