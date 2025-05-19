using AutoMapper;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.BranchDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchsController(IBranchService _branchService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var values = await _branchService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet("FindBrancName")]
        public async Task<IActionResult> GetFingBranchName(string name)
        {
            var values = await _branchService.GetFindBrancName(name);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(CreateBranchDto createBranchDto)
        {
            var value = await _branchService.AddAsync(createBranchDto);
            if (value.Success)
                return Ok(value);
            return BadRequest(value);
        }
    }
}
