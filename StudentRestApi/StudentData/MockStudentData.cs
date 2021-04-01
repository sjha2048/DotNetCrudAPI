using StudentRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRestApi.StudentData
{
    public class MockStudentData : IStudentData
    {
        private List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Student one"
            },
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Student two"
            }
        };
        public Student AddStudent(Student student)
        {
            student.Id = Guid.NewGuid();
            students.Add(student);
            return student;
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
        }

        public Student EditStudent(Student student)
        {
            var existingStudent = GetStudent(student.Id);
            existingStudent.Name = student.Name;
            return existingStudent;
        }

        public Student GetStudent(Guid id)
        {
            return students.SingleOrDefault(x => x.Id == id);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
