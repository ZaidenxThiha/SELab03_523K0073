using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentEnrollmentRepository
    {
        private readonly Exer3DbContext _context = new Exer3DbContext();

        public void AddStudentEnrollment(StudentEnrollment enrollment)
        {
            _context.StudentEnrollments.Add(enrollment);
            _context.SaveChanges();
        }

        public StudentEnrollment GetStudentEnrollment(int studentId, int courseId)
        {
            return _context.StudentEnrollments.FirstOrDefault(se => se.StudentId == studentId && se.CourseId == courseId);
        }

        public List<StudentEnrollment> GetAllStudentEnrollments()
        {
            return _context.StudentEnrollments.ToList();
        }

        public void UpdateStudentEnrollment(StudentEnrollment enrollment)
        {
            var existing = _context.StudentEnrollments.FirstOrDefault(se => se.StudentId == enrollment.StudentId && se.CourseId == enrollment.CourseId);
            if (existing != null)
            {
                existing.EnrollmentDate = enrollment.EnrollmentDate;
                _context.SaveChanges();
            }
        }

        public void DeleteStudentEnrollment(int studentId, int courseId)
        {
            var enrollment = _context.StudentEnrollments.FirstOrDefault(se => se.StudentId == studentId && se.CourseId == courseId);
            if (enrollment != null)
            {
                _context.StudentEnrollments.Remove(enrollment);
                _context.SaveChanges();
            }
        }
    }
}