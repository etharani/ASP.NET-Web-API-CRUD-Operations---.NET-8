using Crud_System.Data;
using Crud_System.Models;
using Crud_System.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_System.Controllers
{
    //localhost/***/api/controller
    [Route("api/[controller]")]
    [ApiController]

    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDpContext dpContext;

        public StudentsController(ApplicationDpContext dpContext)
        {
            this.dpContext = dpContext;
        }
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var allStudent = dpContext.students.ToList();
            return Ok(allStudent);
            //return  ok(dpContext.students.ToList());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetStudent(Guid id) 
        {
            var student=dpContext.students.Find(id);
            if(student == null)
            {
                return NotFound(id);
            }
            else
            {
                return Ok(student);
            }

        }

        [HttpPost]
        public IActionResult AddStudent(AddStudent addStudent)
        {
            var StudentEntity = new student()
            {
                StuName = addStudent.StuName,
                StuAddress = addStudent.StuAddress,
                StuSalary = addStudent.StuSalary,
                StuAge = addStudent.StuAge
            };
            dpContext.students.Add(StudentEntity);
            dpContext.SaveChanges();
            return Ok(StudentEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult UpdateStudent(Guid id,UpdateStudent updateStudent)
        {
            var student = dpContext.students.Find(id);
            if (student is null)
            {
                return NotFound(id);
            }
            student.StuName = updateStudent.StuName;
            student.StuAddress= updateStudent.StuAddress;   
            student.StuAge = updateStudent.StuAge;  
            student.StuSalary = updateStudent.StuSalary;

            dpContext.SaveChanges();
            return Ok(student);

        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteStudent(Guid id)
        {
            var student= dpContext.students.Find(id);
            if (student is null)
            {
                return NotFound(id);
            }
            else
            {
                dpContext.students.Remove(student);
                dpContext.SaveChanges();
                return Ok("Succesfull Delete "+id);
            }
        }

    }
}
