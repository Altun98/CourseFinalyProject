using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwardsTypesController(IAwardsTypeService _awardsTypeService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _awardsTypeService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
    }
}
