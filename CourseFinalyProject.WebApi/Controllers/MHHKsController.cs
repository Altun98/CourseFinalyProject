using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.MHHKDtos;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MHHKsController(IMHHKService _mHHKService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetAll")]     
        public async Task<IActionResult> GetAll()
        {
            var values = await _mHHKService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("GetFindEmployee")]
        public async Task<IActionResult> GetFindEmployee(int empId)
        {
            var values = await _mHHKService.GetFindEmployee(empId);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _mHHKService.GetById(id);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }

        [HttpGet("GetFindMHHKDocNumber")]
        public async Task<IActionResult> GetFindMHHKDocNumber(string number)
        {
            var values = await _mHHKService.GetFindMHHKDocNumber(number);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("GetDocdateControl")]
        public async Task<IActionResult> GetDocdateControl(DateTime start, DateTime end)
        {
            var values = await _mHHKService.GetDocdateControl(start, end);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("GetFindFeedback")]
        public async Task<IActionResult> GetFindFeedback(string gfedback)
        {
            var values = await _mHHKService.GetFindFeedback(gfedback);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("GetFindCompany")]
        public async Task<IActionResult> GetFindCompany(string company)
        {
            var values = await _mHHKService.GetFindCompany(company);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("GetFindDiagnosis")]
        public async Task<IActionResult> GetFindDiagnosis(string diagnostic)
        {
            var values = await _mHHKService.GetFindDiagnosis(diagnostic);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }

        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateMHHKDto createMHHKDto)
        {
            var value = await _mHHKService.AddAsync(createMHHKDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(ResultMHHKDto resultMHHKDto)
        {
            var value = await _mHHKService.DeleteAsync(resultMHHKDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateMHHKDto updateMHHKDto)
        {
            var value = await _mHHKService.UpdateAsync(updateMHHKDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
