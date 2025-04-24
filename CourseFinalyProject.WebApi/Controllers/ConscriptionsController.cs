using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConscriptionsController : ControllerBase
    {
        private readonly IConscriptioService _conscriptioService;
        public ConscriptionsController(IConscriptioService conscriptioService)
        {
            _conscriptioService = conscriptioService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var value = await _conscriptioService.GetAll();
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int employeeId)
        {
            var value = await _conscriptioService.GetByID(employeeId);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpGet("getdeparyament")]
        public async Task<IActionResult> GetDepartamentDetails(int departamentId)
        {
            var value = await _conscriptioService.GetDepartamentID(departamentId);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(ConscriptionDto conscriptionDto)
        {
            var value = await _conscriptioService.Added(conscriptionDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(int employeeId)
        {
            var value = await _conscriptioService.GetByID(employeeId);
            foreach (var item in value.Data)
            {
                var result = _conscriptioService.Deleted(item);
            }
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("updated")]
        public async Task<IActionResult> Updated(ConscriptionDto conscriptionDto)
        {
            var value = await _conscriptioService.Updated(conscriptionDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
