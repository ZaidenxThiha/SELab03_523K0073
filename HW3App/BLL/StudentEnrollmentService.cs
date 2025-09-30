using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class StudentEnrollmentService
    {
        private readonly StudentEnrollmentRepository _repository = new StudentEnrollmentRepository();

        public void AddStudentEnrollment(StudentEnrollment enrollment)
        {
            if (enrollment.StudentId <= 0 || enrollment.CourseId <= 0)
                throw new ArgumentException("Valid student and course IDs are required.");
            if (enrollment.EnrollmentDate == default(DateTime))
                throw new ArgumentException("Enrollment date is required.");
            _repository.AddStudentEnrollment(enrollment);
        }

        public StudentEnrollment GetStudentEnrollment(int studentId, int courseId)
        {
            return _repository.GetStudentEnrollment(studentId, courseId);
        }

        public List<StudentEnrollment> GetAllStudentEnrollments()
        {
            return _repository.GetAllStudentEnrollments();
        }

        public void UpdateStudentEnrollment(StudentEnrollment enrollment)
        {
            if (enrollment.StudentId <= 0 || enrollment.CourseId <= 0)
                throw new ArgumentException("Valid student and course IDs are required.");
            _repository.UpdateStudentEnrollment(enrollment);
        }

        public void DeleteStudentEnrollment(int studentId, int courseId)
        {
            if (studentId <= 0 || courseId <= 0)
                throw new ArgumentException("Valid student and course IDs are required.");
            _repository.DeleteStudentEnrollment(studentId, courseId);
        }
    }
}
