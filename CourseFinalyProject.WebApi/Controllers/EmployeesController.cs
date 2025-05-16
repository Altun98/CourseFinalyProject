using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using CourseFinalyProject.Entities.DTOs.EmployeeDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employee;
        public EmployeesController(IEmployeeService employee)
        {
            _employee = employee;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _employee.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getemployeesdetails")]
        public async Task<IActionResult> GetEmployeesDetails()
        {
            var result = await _employee.GetEmployeeDetailsAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateEmployeeDto employee)
        {
            var result = await _employee.EmployeeAddedAsync(employee);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deteted(ResultEmployeeDto dto)
        {
            var result = await _employee.EmployeeDeleteAsync(dto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
    }
}
