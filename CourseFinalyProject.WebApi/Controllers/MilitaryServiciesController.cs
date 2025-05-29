using AutoMapper;
using Core.Utilities.Results.Data;
using CourseFinalyProject.Business.Abstract;
using CourseFinalyProject.Entities.DTOs.MilitaryServiceDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MilitaryServiciesController(IMilitaryServiceService _militaryServiceService, IMapper _mapper) : ControllerBase
    {        
        //Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindBrancAsync(string branc);
        //Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindDepartamentAsync(string departament);
        //Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindPositionAsync(string position);
        //Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindBrancControlDocDateAsync(string branc, DateTime _start, DateTime _end);
        //Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindDepartamentControlDocDateAsync(string departament, DateTime _start, DateTime _end);
        //Task<IDataResult<List<DetailMilitaryServiceDto>>> GetFindPosiationControlDocDateAsync(string position, DateTime _start, DateTime _end);
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _militaryServiceService.GetAllAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetIsMain()
        {
            var values = await _militaryServiceService.GetIsMainAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetNotIsMain()
        {
            var values = await _militaryServiceService.GetNotIsMainAsync();
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetByEmployeId(int empID)
        {
            var values = await _militaryServiceService.GetByEmployeIdAsync(empID);
            if (values.Success)
                return Ok(values);
            return BadRequest(values);
        }

    }
}
