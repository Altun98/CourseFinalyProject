using AutoMapper;
using Core.Utilities.Results.NonData;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MilitaryRanksController : ControllerBase
    {
        private readonly IMilitaryRankService _militaryRank;
        private readonly IMapper _mapper;
        public MilitaryRanksController(IMilitaryRankService militaryRank, IMapper mapper)
        {
            _militaryRank = militaryRank;
            _mapper = mapper;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _militaryRank.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);

        }
        [HttpGet("employeranks")]
        public async Task<IActionResult> GetEmployeeRank(int empId)
        {
            var result = await _militaryRank.GetEmployeeRanksInfo(empId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("added")]
        public async Task<IActionResult> RankAdded(MilitaryRankDto rankDto)
        {
            var result = await _militaryRank.MilitaryRankAdded(rankDto);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("employeerankdetails")]
        public async Task<IActionResult> employeerankdetails(int empId)
        {
            var rankResult = await _militaryRank.GetRankSEmployeeDetailsInfo(empId);
            if (rankResult.Success)
                return Ok(rankResult);
            return BadRequest(rankResult);
        }
    }
}
