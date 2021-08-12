
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiessController : ControllerBase
    {
        private ICitiesService _citiesService;

        public CitiessController(ICitiesService citiesService)
        {
            _citiesService = citiesService;
        }


        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _citiesService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

    }
}
