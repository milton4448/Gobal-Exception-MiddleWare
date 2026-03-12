using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [Route("getStdentList")]
        [HttpGet]
        public List<StudentModel> getAllStudents() 
        { 
            List<StudentModel> students = new List<StudentModel>();
            StudentModel stud1 = new StudentModel()
            {
                Id = 1,
                Name="Milton",
                Age=35,
                phone="9862394444",
                IsActive=true
            };

            students.Add(stud1);


            StudentModel stud2 = new StudentModel()
            {
                Id = 2,
                Name = "Nabi",
                Age = 35,
                phone = "9862394449",
                IsActive = true
            };

            students.Add(stud2);

            return students;
        }

    }
}
