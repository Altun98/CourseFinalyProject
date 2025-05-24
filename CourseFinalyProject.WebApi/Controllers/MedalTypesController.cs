using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.MedalTypeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MedalTypesController(IMedalTypeService _medalTypeService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _medalTypeService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateMedalTypeDto createMedalTypeDto)
        {
            var value = await _medalTypeService.AddAsync(createMedalTypeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest();
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateMedalTypeDto updateMedalTypeDto)
        {
            var value = await _medalTypeService.UpdateAsync(updateMedalTypeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(ResultMedalTypeDto resultMedalTypeDto)
        {
            var value = await _medalTypeService.DeleteAsync(resultMedalTypeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
