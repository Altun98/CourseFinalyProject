using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CombatOperationsController : ControllerBase
    {
        private readonly ICombatOperationsService _combatOperationsService;
        public CombatOperationsController(ICombatOperationsService combatOperationsService)
        {
            _combatOperationsService = combatOperationsService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _combatOperationsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CombatOperationsDto combatOperationsDto)
        {
            var result = await _combatOperationsService.Added(combatOperationsDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getEmployeid")]
        public async Task<IActionResult> getByEmployeeID(int employeeID)
        {
            var result = await _combatOperationsService.GetEmployeeCombatOperation(employeeID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("updated")]
        public async Task<IActionResult> Update(CombatOperationsDto combat)
        {
            var result = await _combatOperationsService.Update(combat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(CombatOperationsDto combat)
        {
            var result = await _combatOperationsService.Delete(combat);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
