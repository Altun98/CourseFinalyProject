using CourseFinalyProject.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IEmployeeService _employee;
        public SearchController(IEmployeeService employee)
        {
            _employee = employee;
        }
    }
}
