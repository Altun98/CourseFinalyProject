using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.AwardsDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AwardsController(IAwardsService _awardsService, IMapper _mapper) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateAwardsDto dto)
        {
            var value = await _awardsService.AddAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateAwardsDto dto)
        {
            var value = await _awardsService.UpdateAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(ResultAwardsDto dto)
        {
            var value = await _awardsService.DeleteAsync(dto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _awardsService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindEmployeeIdAsync(int empId)
        {
            var values = await _awardsService.GetFindEmployeeIdAsync(empId);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindMedalTypeIdAsync(int medalId)
        {
            var values = await _awardsService.GetFindMedalTypeIdAsync(medalId);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindAwardsTypeIdAsync(int awardsTypeId)
        {
            var values = await _awardsService.GetFindAwardsTypeIdAsync(awardsTypeId);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetFindGiveAsync(int giveId)
        {
            var values = await _awardsService.GetFindGiveAsync(giveId);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetControlEmployeIdDateTimeAsync(int empId,DateTime start,DateTime end)
        {
            var values = await _awardsService.GetControlEmployeIdDateTimeAsync(empId, start, end);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetControlMedalTypeIdDateTimeAsync(int medalId, DateTime start, DateTime end)
        {
            var values = await _awardsService.GetControlMedalTypeIdDateTimeAsync(medalId, start, end);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetControlAwardsTypeIdDateTimeAsync(int awardsId,DateTime start,DateTime end)
        {
            var values = await _awardsService.GetControlAwardsTypeIdDateTimeAsync(awardsId, start, end);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetIsBasicAsync()
        {
            var values = await _awardsService.GetIsBasicAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetNotIsBasicAsync()
        {
            var values = await _awardsService.GetNotIsBasicAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
    }
}
