using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DodtGoAbroadsController : ControllerBase
    {
        private readonly IDodtGoAbroadService _dodtGoAbroad;
        private readonly IMapper _mapper;
        public DodtGoAbroadsController(IDodtGoAbroadService dodtGoAbroad, IMapper mapper)
        {
            _dodtGoAbroad = dodtGoAbroad;
            _mapper = mapper;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _dodtGoAbroad.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetByID(int empId)
        {
            var result = await _dodtGoAbroad.GetById(empId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("datatimecontrol")]
        public async Task<IActionResult> GetDataControl(DateTime start, DateTime end)
        {
            var result = await _dodtGoAbroad.GetDataTimeControl(start, end);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("country")]
        public async Task<IActionResult> GetCountry(string country)
        {
            var result = await _dodtGoAbroad.GetCountry(country);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(DodGoAbrodDto goAbrodDto)
        {
            var result = await _dodtGoAbroad.Added(goAbrodDto);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPut("updated")]
        public async Task<IActionResult> Updated(DodGoAbrodDto goAbrodDto)
        {
            var result = await _dodtGoAbroad.Updated(goAbrodDto);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }
        [HttpDelete("deleted")]
        public async Task<IActionResult> Deleted(DodGoAbrodDto goAbrodDto)
        {
            var result = await _dodtGoAbroad.Deleted(goAbrodDto);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
