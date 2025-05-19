using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Business.Constants;
using CourseFinalyProject.Entities.DTOs.GiveDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GivesController(IGiveService _giveService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _giveService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _giveService.GetByIdAsync(id);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }

        [HttpGet("GetNameSearch")]
        public async Task<IActionResult> GetNameSearch(string name)
        {
            var values = await _giveService.GetGiveNameSearchAsync(name);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }

        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateGiveDto createGiveDto)
        {
            await _giveService.AddAsync(createGiveDto);
            return Ok(Messages.Added);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Deleted(ResultGiveDto resultGiveDto)
        {
            var value = await _giveService.DeleteAsync(resultGiveDto);
            return Ok(value);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateGiveDto updateGiveDto)
        {
            var value = await _giveService.UpdateAsync(updateGiveDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
