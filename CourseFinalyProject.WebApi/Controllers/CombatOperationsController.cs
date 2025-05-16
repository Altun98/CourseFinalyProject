using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.CombatOperationsDtos;
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
            var result = await _combatOperationsService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(ResultCombatOperationsDto combatOperationsDto)
        {
            var result = await _combatOperationsService.AddedAsync(combatOperationsDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getEmployeid")]
        public async Task<IActionResult> getByEmployeeID(int employeeID)
        {
            var result = await _combatOperationsService.GetEmployeeCombatOperationAsync(employeeID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("updated")]
        public async Task<IActionResult> Update(ResultCombatOperationsDto combat)
        {
            var result = await _combatOperationsService.UpdateAsync(combat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(ResultCombatOperationsDto combat)
        {
            var result = await _combatOperationsService.DeleteAsync(combat);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
