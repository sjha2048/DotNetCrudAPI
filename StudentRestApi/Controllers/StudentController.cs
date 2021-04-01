using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentRestApi.Models;
using StudentRestApi.StudentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRestApi.Controllers
{
    
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentData _studentData;
        public StudentController(IStudentData studentData)
        {
            _studentData = studentData;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetStudents()
        {
            return Ok(_studentData.GetStudents());

        }
        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetStudent(Guid id)
        {
            var student = _studentData.GetStudent(id);
            if (student != null)
            {
                return Ok(student);
            }

            return NotFound($"Student with id: {id} was not found");

        }
        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddStudent(Student student)
        {
             _studentData.AddStudent(student);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + student.Id,
                student);

        }
        [HttpDelete]
        [Route("api/[controller]/{id}")]

        public IActionResult DeleteStudent(Guid id)
        {
            var student = _studentData.GetStudent(id);

            if(student != null)
            {
                _studentData.DeleteStudent(student);
                return Ok();
            }

            return NotFound($"Student with {id} not found");

        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]

        public IActionResult EditStudent(Guid id, Student student)
        {
            var existingStudent = _studentData.GetStudent(id);

            if (existingStudent != null)
            {
                student.Id = existingStudent.Id;
                _studentData.EditStudent(student);    
            }

            return Ok(student);

        }

    }
}
