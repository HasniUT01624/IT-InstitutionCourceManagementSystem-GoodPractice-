using IT_Institution.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT_Institution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController (IStudentService studentService)
        {
            _studentService = studentService;
        }
    }
}
