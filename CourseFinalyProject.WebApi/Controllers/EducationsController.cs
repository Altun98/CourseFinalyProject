using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Education;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        IEducationService _education;
        public EducationsController(IEducationService education)
        {
            _education = education;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _education.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getemployeeducationdetailsinfo")]
        public async Task<IActionResult> GetemployeeEducationDetailsInfo(int empId)
        {
            var edu = await _education.GetEmployeeEducationInfoAsync(empId);
            if (edu.Success)
                return Ok(edu);
            return BadRequest(edu);
        }
        [HttpPost("added")]
        public async Task<IActionResult> EduAdd(ResultEducationDto education)
        {
            var result = await _education.EducationAddAsync(education);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public async Task<IActionResult> EduUpdate(ResultEducationDto educationDto)
        {
            var result = await _education.EducationUpdateAsync(educationDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
