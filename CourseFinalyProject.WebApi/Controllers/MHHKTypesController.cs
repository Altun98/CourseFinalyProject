using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.MHHKTypeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MHHKTypesController(IMHHKTypeService _mHHKTypeService, IMapper _mapper) : ControllerBase
    {
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateMHHKTypeDto createMHHKTypeDto)
        {
            var value = await _mHHKTypeService.AddAsync(createMHHKTypeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateMHHKTypeDto updateMHHKTypeDto)
        {
            var value = await _mHHKTypeService.UpdateAsync(updateMHHKTypeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(ResultMHHKTypeDto resultMHHKTypeDto)
        {
            var value = await _mHHKTypeService.DeleteAsync(resultMHHKTypeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _mHHKTypeService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }

    }
}
