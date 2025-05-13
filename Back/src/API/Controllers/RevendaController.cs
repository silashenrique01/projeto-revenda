using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Responses;
using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RevendaController : ControllerBase
    {

        private readonly ILogger<RevendaController> _logger;
        private readonly IRevendaService _revendaService;

        public RevendaController(ILogger<RevendaController> logger, IRevendaService RevendaService)
        {
            _logger = logger;
            _revendaService = RevendaService;
        }

        [HttpGet]
        public async Task<ApiResponse<IList<RevendaDto>>> Get()
        {
            try
            {
                var result = await _revendaService.GetAllRevendas();

                if (result == null) return ApiResponse<IList<RevendaDto>>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");

                return ApiResponse<IList<RevendaDto>>.Success(result);
            }
            catch(Exception ex) {

                return ApiResponse<IList<RevendaDto>>.Error(500, ex.Message);
            }   
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<RevendaDto>> GetById(Guid id)
        {
            try
            {
                var result = await _revendaService.GetRevenda(id);

                if (result == null) return ApiResponse<RevendaDto>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");

                return ApiResponse<RevendaDto>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<RevendaDto>.Error(500, ex.Message);
            }
        }



        [HttpPost]
        public async Task<ApiResponse<RevendaDto>> Post(RevendaDto revendaDto)
        {
            try
            {
                var result = await _revendaService.AddRevenda(revendaDto);
                if (result == null) return ApiResponse<RevendaDto>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");

                return ApiResponse<RevendaDto>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<RevendaDto>.Error(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ApiResponse<RevendaDto>> Put(Guid id, RevendaDto revendaDto)
        {
            try
            {

                var result = await _revendaService.UpdateRevenda(id, revendaDto);

                if (result == null) return ApiResponse<RevendaDto>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");

                return ApiResponse<RevendaDto>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<RevendaDto>.Error(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ApiResponse<bool>> Delete(Guid id)
        {
            try
            {

                var result = await _revendaService.DeleteRevenda(id);

                if (!result) return ApiResponse<bool>.Error(BadRequest().StatusCode, "O objeto não foi deletado.");

                return ApiResponse<bool>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<bool>.Error(500, ex.Message);
            }
        }
    }
}
