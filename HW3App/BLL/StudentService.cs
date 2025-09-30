using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class StudentService
    {
        private readonly StudentRepository _repository = new StudentRepository();

        public void AddStudent(Student student)
        {
            if (string.IsNullOrEmpty(student.Name))
                throw new ArgumentException("Student name is required.");
            if (student.DepartmentId <= 0)
                throw new ArgumentException("Valid department ID is required.");
            _repository.AddStudent(student);
        }

        public Student GetStudent(int id)
        {
            return _repository.GetStudentById(id);
        }

        public List<Student> GetAllStudents()
        {
            return _repository.GetAllStudents();
        }

        public void UpdateStudent(Student student)
        {
            if (student == null || student.Id <= 0)
                throw new ArgumentException("Invalid student data.");
            _repository.UpdateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid student ID.");
            _repository.DeleteStudent(id);
        }
    }
}