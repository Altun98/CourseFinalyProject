using AutoMapper;
using AutoMapper.Configuration.Annotations;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.EmployeeFamilyMemberDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeFamilyMembersController(IEmployeeFamilyMemberService _employeeFamily, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _employeeFamily.TGetAllAsync();
            if (values != null)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeID(int id)
        {
            var values = await _employeeFamily.TGetEmployeeID(id);
            if (values != null)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateEmployeeFamilyMemberDto createEmployeeFamilyMemberDto)
        {
            var value = await _employeeFamily.TAddAsync(createEmployeeFamilyMemberDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(ResultEmployeeFamilyMemberDto resultEmployeeFamilyMemberDto)
        {
            var value = await _employeeFamily.TDeleteAsync(resultEmployeeFamilyMemberDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateEmployeeFamilyMemberDto updateEmployeeFamilyMemberDto)
        {
            var value = await _employeeFamily.TUpdateAsync(updateEmployeeFamilyMemberDto);
            if (value.Success)
                return Ok(value);
            return Ok(value);
        }
    }
}
