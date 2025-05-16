using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesInfoController : ControllerBase
    {
        IEmployeeInfoService _employeeInfo;
        public EmployeesInfoController(IEmployeeInfoService employeeInfo)
        {
            _employeeInfo = employeeInfo;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _employeeInfo.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetByID(int id)
        {
            var result = await _employeeInfo.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(ResultEmployeeInfoDto employeeInfoDto)
        {
            var result = await _employeeInfo.EmployeeInfoAddedAsync(employeeInfoDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(ResultEmployeeInfoDto employeeInfoDto)
        {
            var result = await _employeeInfo.EmployeeInfoDeletedAsync(employeeInfoDto);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result);
        }

        [HttpGet("searchbloodType")]
        public async Task<IActionResult> GetSearchBloodTypeID(int bloodID)
        {
            var result = await _employeeInfo.GetSearchBloodTypeIdAsync(bloodID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
