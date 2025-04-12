using Microsoft.AspNetCore.Mvc;

namespace CourseFinalyProject.UI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
