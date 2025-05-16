using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.ConscriptionDtos;
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
            var value = await _conscriptioService.GetAllAsync();
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int employeeId)
        {
            var value = await _conscriptioService.GetByIDAsync(employeeId);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpGet("getdeparyament")]
        public async Task<IActionResult> GetDepartamentDetails(int departamentId)
        {
            var value = await _conscriptioService.GetDepartamentIdAsync(departamentId);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(ResultConscriptionDto conscriptionDto)
        {
            var value = await _conscriptioService.AddedAsync(conscriptionDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(int employeeId)
        {
            var value = await _conscriptioService.GetByIDAsync(employeeId);
            foreach (var item in value.Data)
            {
                var result = _conscriptioService.DeletedAsync(item);
            }
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("updated")]
        public async Task<IActionResult> Updated(ResultConscriptionDto conscriptionDto)
        {
            var value = await _conscriptioService.UpdatedAsync(conscriptionDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
