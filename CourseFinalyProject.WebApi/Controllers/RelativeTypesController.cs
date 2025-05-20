using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.RelativeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelativeTypesController(IRelativeTypeService _relativeTypeService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _relativeTypeService.GetAllAsync();
            if (!values.Success)
                return BadRequest(values);
            return Ok(values);
        }
        [HttpGet("GetFindName")]
        public async Task<IActionResult> GetFindName(string name)
        {
            var values = await _relativeTypeService.GetFindRelativeName(name);
            if (!values.Success)
                return BadRequest(values);
            return Ok(values);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateRelativeDto createRelativeDto)
        {
            var value = await _relativeTypeService.AddAsync(createRelativeDto);
            if (!value.Success)
                return BadRequest(value);
            return Ok(value);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateRelativeDto updateRelativeDto)
        {
            var value = await _relativeTypeService.UpdateAsync(updateRelativeDto);
            if (!value.Success)
                return BadRequest(value);
            return Ok(value);
        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(ResultRelativeDto resultRelativeDto)
        {
            var value = await _relativeTypeService.DeleteAsync(resultRelativeDto);
            if (!value.Success)
                return BadRequest(value);
            return Ok(value);
        }
    }
}
