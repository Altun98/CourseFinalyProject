using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.AcademicDegreeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicDegreesController(IAcademicDegreeService _academicDagger, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _academicDagger.GetAllAsync();
            if (values.Success)
                return Ok(values.Data);
            return BadRequest(values.Message);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateAcademicDegreeDto createAcademicDegreeDto)
        {
            var value = await _academicDagger.AddedAsync(createAcademicDegreeDto);
            if (value.Success) return Ok(value);
            return BadRequest(value.Message);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateAcademicDegreeDto updateAcademicDegreeDto)
        {
            var value = await _academicDagger.UpdateAsync(updateAcademicDegreeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(ResultAcademicDegreeDto resultAcademicDegreeDto)
        {
            var value = await _academicDagger.DeleteAsync(resultAcademicDegreeDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
