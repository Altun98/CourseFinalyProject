using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.Concrete;
using CourseFinalyProject.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttestationsController : ControllerBase
    {
        private readonly IAttestationService _attestation;
        public AttestationsController(IAttestationService attestation)
        {
            _attestation = attestation;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result =await _attestation.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("added")]
        public async Task<IActionResult> Added(AttestationDto attestationDto)
        {
            var result = await _attestation.Added(attestationDto);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("employeattestationdetails")]
        public async Task<IActionResult> GetEmpAttList(int empId)
        {
            var result = await _attestation.GetEmployeesAttestationsInfo(empId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
