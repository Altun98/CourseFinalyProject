using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.BloodTypeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodTypesController(IBloodTypeService _bloodTypeService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _bloodTypeService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("GetBloodTypeNameSearch")]
        public async Task<IActionResult> GetBloodTypeNameSearch(string _search)
        {
            var values = await _bloodTypeService.GetBloodTypeNameSearch(_search);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateBloodTypeDto createBloodTypeDto)
        {
            var value = await _bloodTypeService.AddAsync(createBloodTypeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Deleted(ResultBloodTypeDto resultBloodTypeDto)
        {
            var value = await _bloodTypeService.DeleteAsync(resultBloodTypeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Updated(UpdateBloodType updateBloodType)
        {
            var value = await _bloodTypeService.UpdateAsync(updateBloodType);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
