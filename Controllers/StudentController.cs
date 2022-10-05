using Microsoft.AspNetCore.Mvc;
using OData.New.Models;
using OData.New.Services;

namespace Name.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudenController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudenController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public ActionResult<IQueryable<Student>> GetAllStudents()
        {
            IQueryable<Student> retrievedStudents = 
                this.studentService.RetrieveAllStudents();
            return Ok(retrievedStudents);
        }
    }
}