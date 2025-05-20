using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MHHKsController(IMHHKService _mHHKService,IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _mHHKService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
    }
}
