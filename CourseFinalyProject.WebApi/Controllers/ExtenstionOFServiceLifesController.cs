using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.ExtenstionOFServiceLifeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtenstionOFServiceLifesController(IExtenstionOFServiceLifeService _extenstionService,IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _extenstionService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var values = await _extenstionService.GetByIdAsync(id);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("getbyemployeid")]
        public async Task<IActionResult> GetByEmployeeId(int empId)
        {
            var value = await _extenstionService.GetByEmployeeIdAsync(empId);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }

        [HttpGet("GetStartDateTimeControl")]
        public async Task<IActionResult> GetStartDateTimeControl(DateTime _start, DateTime _end)
        {
            var values = await _extenstionService.GetStartDateTimeControl(_start, _end);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("GetEndDateTimeControl")]
        public async Task<IActionResult> GetEndDateTimeControl(DateTime _start, DateTime _end)
        {
            var values = await _extenstionService.GetEndDateTimeControl(_start, _end);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }

        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateExtenstionOFServiceLifeDto createExtenstionOFServiceLifeDto)
        {
            var value = await _extenstionService.AddAsync(createExtenstionOFServiceLifeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(ResultExtenstionOFServiceLifeDto resultExtenstionOFServiceLifeDto)
        {
            var value = await _extenstionService.DeleteAsync(resultExtenstionOFServiceLifeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateExtenstionOFServiceLifeDto updateExtenstionOFServiceLifeDto)
        {
            var value = await _extenstionService.UpdateAsync(updateExtenstionOFServiceLifeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
