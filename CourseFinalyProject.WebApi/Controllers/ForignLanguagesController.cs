using AutoMapper;
using Core.Utilities.Results.Data;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.ForignLanguageDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ForignLanguagesController(IForignLanguageService _forignLanguageService, IMapper _mapper) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateForignLanguage dto)
        {
            var value = await _forignLanguageService.AddAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateForignLanguag dto)
        {
            var value = await _forignLanguageService.UpdateAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(ResultForignLanguage dto)
        {
            var value = await _forignLanguageService.DeleteAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _forignLanguageService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetIsIndefinitely()
        {
            var values = await _forignLanguageService.GetIsIndefinitely();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetNotIsIndefinitely()
        {
            var values = await _forignLanguageService.GetNotIsIndefinitely();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindEmployeeId(int empId)
        {
            var values = await _forignLanguageService.GetFindEmployeeIdAsync(empId);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindLanguageId(int language)
        {
            var values = await _forignLanguageService.GetFindLanguageIdAsync(language);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindGiveId(int giveId)
        {
            var values = await _forignLanguageService.GetFindGiveIdAsync(giveId);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindPercentage(int percentage)
        {
            var values = await _forignLanguageService.GetFindPercentageAsync(percentage);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetIsIndefinitelyControlEndDateTime(DateTime start, DateTime _end)
        {
            var values = await _forignLanguageService.GetIsIndefinitelyControlEndDateTime(start, _end);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindLanguageControlEndDateTime(int language, DateTime _start, DateTime _end)
        {
            var values = await _forignLanguageService.GetFindLanguageControlEndDateTime(language, _start, _end);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }        
    }
}
