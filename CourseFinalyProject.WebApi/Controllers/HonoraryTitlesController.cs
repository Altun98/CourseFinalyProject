using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.HonoraryTitleDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HonoraryTitlesController(IHonoraryTitleService _honoraryTitleService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _honoraryTitleService.GetAllAsync();
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateHonoraryTitleDto createHonoraryTitleDto)
        {
            var value = await _honoraryTitleService.AddAsync(createHonoraryTitleDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateHonoraryTitleDto updateHonoraryTitleDto)
        {
            var value = await _honoraryTitleService.UpdateAsync(updateHonoraryTitleDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(ResultHonoraryTitleDto resultHonoraryTitleDto)
        {
            var value = await _honoraryTitleService.DeleteAsync(resultHonoraryTitleDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
