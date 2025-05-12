using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                var result = new List<Revenda>{new Revenda("123456789", "teste", "teste2", "email", new List<string> { "123456789", "123456789" }, null, null}
                ,{ new Revenda("123456789", "teste", "teste2", "email", new List<string> { "123456789", "123456789" }, null, null};
               

                return ApiResponse<IList<Revenda>>.Success(result);
            }
            catch(Exception ex) {

                return ApiResponse<IList<Revenda>>.Error(500, "Error");
            }   
        }
    }
}
