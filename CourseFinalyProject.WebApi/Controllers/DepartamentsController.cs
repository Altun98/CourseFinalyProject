using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.DepartamentDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentsController(IDepartamentService _departamentService,IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _departamentService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _departamentService.GetByIdAsync(id);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpGet("getdepartamentname")]
        public async Task<IActionResult> GetDepartamentName(string name)
        {
            var value = await _departamentService.GetDepartamentName(name);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateDepartamentDto createDepartamentDto)
        {
            var value = await _departamentService.AddAsync(createDepartamentDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(ResultDepartamentDto resultDepartamentDto)
        {
            var value = await _departamentService.DeleteAsync(resultDepartamentDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Updated(UpdateDepartamentDto updateDepartamentDto)
        {
            var value = await _departamentService.UpdateAsync(updateDepartamentDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
