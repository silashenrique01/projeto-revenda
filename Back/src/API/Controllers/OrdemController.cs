﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API.Responses;
using Application.Dtos;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Polly.Retry;
using Polly;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdemController : ControllerBase
    {
        private readonly ILogger<OrdemController> _logger;
        private readonly IOrdemService _ordemService;

        public OrdemController(ILogger<OrdemController> logger, IOrdemService OrdemService)
        {
            _logger = logger;
            _ordemService = OrdemService;
        }

        [HttpGet]
        public async Task<ApiResponse<IList<OrdemDto>>> Get()
        {
            try
            {
                _logger.LogInformation("Recebendo requisição para buscar pedidos...");

                var result = await _ordemService.GetAllOrdens();

                if (result == null)
                {
                    _logger.LogWarning("Nenhum pedido encontrado!");
                    return ApiResponse<IList<OrdemDto>>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");
                }

                _logger.LogInformation("Requisição dos pedidos realizada com sucesso!");
                return ApiResponse<IList<OrdemDto>>.Success(result);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao encontrar os pedidos");
                return ApiResponse<IList<OrdemDto>>.Error(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ApiResponse<OrdemDto>> GetById(Guid id)
        {
            try
            {
                var result = await _ordemService.GetOrdemById(id);

                if (result == null) return ApiResponse<OrdemDto>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");

                return ApiResponse<OrdemDto>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<OrdemDto>.Error(500, ex.Message);
            }
        }


        [HttpGet("GetByRevenda/{id}")]
        public async Task<ApiResponse<IList<OrdemDto>>> GetByRevenda(Guid id)
        {
            try
            {
                var result = await _ordemService.GetOrdemByRevenda(id);

                if (result == null) return ApiResponse<IList<OrdemDto>>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");

                return ApiResponse<IList<OrdemDto>>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<IList<OrdemDto>>.Error(500, ex.Message);
            }
        }



        [HttpPost]
        public async Task<ApiResponse<OrdemDto>> Post(OrdemDto ordemDto)
        {
            try
            {
                var result = await _ordemService.AddOrdem(ordemDto);
                if (result == null) return ApiResponse<OrdemDto>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");

                return ApiResponse<OrdemDto>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<OrdemDto>.Error(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ApiResponse<OrdemDto>> Put(Guid id, OrdemDto ordemDto)
        {
            try
            {

                var result = await _ordemService.UpdateOrdem(id, ordemDto);

                if (result == null) return ApiResponse<OrdemDto>.Error(NoContent().StatusCode, "Nenhum objeto encontrado");

                return ApiResponse<OrdemDto>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<OrdemDto>.Error(500, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ApiResponse<bool>> Delete(Guid id)
        {
            try
            {

                var result = await _ordemService.DeleteOrdem(id);

                if (!result) return ApiResponse<bool>.Error(BadRequest().StatusCode, "O objeto não foi deletado.");

                return ApiResponse<bool>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<bool>.Error(500, ex.Message);
            }
        }

        //MOCK
        [HttpPost("pedidos-revenda")]
        public IActionResult CriarPedido([FromBody] OrdemDto ordemRevendaDto)
        {
            if (ordemRevendaDto.Produtos.Sum(i => i.Quantidade) < 1000)
            {
                return BadRequest(new { status = "Erro", mensagem = "Pedido mínimo de 1000 unidades não atingido!" });
            }
            else
            {
                return Ok(new { OrdemRevendaId = Guid.NewGuid(), status = "Processado", mensagem = "Pedido recebido com sucesso" });
            }

        }
    }
}
