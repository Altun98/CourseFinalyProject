using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.LanguageDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController(ILanguageService _languageService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var value = await _languageService.GetAllAsync();
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateLanguageDto createLanguageDto)
        {
            var value = await _languageService.AddAsync(createLanguageDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Deleted(ResultLanguageDto resultLanguageDto)
        {
            var value = await _languageService.DeleteAsync(resultLanguageDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateLanguageDto updateLanguageDto)
        {
            var value = await _languageService.UpdateAsync(updateLanguageDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
