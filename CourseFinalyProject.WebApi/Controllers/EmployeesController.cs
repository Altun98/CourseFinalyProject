using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
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
            var result = await _employee.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getemployeesdetails")]
        public async Task<IActionResult> GetEmployeesDetails()
        {
            var result = await _employee.GetEmployeeDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(EmployeeDto employee)
        {
            var result = await _employee.EmployeeAdded(employee);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deteted(EmployeeDto dto)
        {
            var result = await _employee.EmployeeDelete(dto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
    }
}
