using Microsoft.AspNetCore.Mvc;
using Student_Project.Repository;

namespace Student_Project.Controllers
{
    [ApiController]
    [Route("students")]
    public class StudentController : Controller
    {
            private readonly IstudentRepository studentRepository;

            public StudentController(IstudentRepository studentRepository)
            {
                this.studentRepository = studentRepository;
            }

            [HttpGet]
            [ActionName("GetAllRecord")]
            public async Task<IActionResult> GetAllRecord()
            {
                var record = await studentRepository.GetAll();

                //return dto records


                return Ok(record);
            }
        
    }
}
