using StudentRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRestApi.StudentData
{
    public class SqlStudentData : IStudentData
    {
        private StudentContext _studentContext;
        public SqlStudentData(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public Student AddStudent(Student student)
        {
            student.Id = Guid.NewGuid();
            _studentContext.Students.Add(student);
            _studentContext.SaveChanges();
            return student;
        }

        public void DeleteStudent(Student student)
        {
 
             _studentContext.Students.Remove(student);
            _studentContext.SaveChanges();
    
        }

        public Student EditStudent(Student student)
        {
            var existingStudent = _studentContext.Students.Find(student.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.LastName = student.LastName;
                existingStudent.RollNo = student.RollNo;

                _studentContext.Students.Update(existingStudent);
                _studentContext.SaveChanges();
                
            }
            return student;
        }

        public Student GetStudent(Guid id)
        {
            var student = _studentContext.Students.Find(id);
            return student;

            
        }

        public List<Student> GetStudents()
        {
            return _studentContext.Students.ToList();
        }
    }
}
