using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsTypeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AwardsTypesController(IAwardsTypeService _awardsTypeService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _awardsTypeService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAwardsTypeDto dto)
        {
            var value = await _awardsTypeService.AddAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateAwardsTypeDto dto)
        {
            var value = await _awardsTypeService.UpdateAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(ResultAwardsTypeDto dto)
        {
            var value = await _awardsTypeService.DeleteAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
