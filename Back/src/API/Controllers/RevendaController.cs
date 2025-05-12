using System;
using System.Collections.Generic;
using API.Responses;
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

        public RevendaController(ILogger<RevendaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ApiResponse<IList<Revenda>> Get()
        {
            try
            {
                return ApiResponse<IList<Revenda>>.Success(null);
            }
            catch(Exception ex) {

                return ApiResponse<IList<Revenda>>.Error(500, "Error");
            }   
        }
    }
}
