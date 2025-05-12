using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Responses;
using Application.Interfaces;
using Domain;
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

        public RevendaController(ILogger<RevendaController> logger, IRevendaService revendaService)
        {
            _logger = logger;
            _revendaService = revendaService;
        }

        [HttpGet]
        public async Task<ApiResponse<IList<Revenda>>> Get()
        {
            try
            {
                var result = await _revendaService.GetAllRevendas();

                return ApiResponse<IList<Revenda>>.Success(result);
            }
            catch(Exception ex) {

                return ApiResponse<IList<Revenda>>.Error(500, ex.Message);
            }   
        }

        [HttpPost]
        public async Task<ApiResponse<Revenda>> Post(Revenda revenda)
        {
            try
            {
                var result = await _revendaService.AddRevenda(revenda);

                return ApiResponse<Revenda>.Success(result);
            }
            catch (Exception ex)
            {

                return ApiResponse<Revenda>.Error(500, ex.Message);
            }
        }
    }
}
