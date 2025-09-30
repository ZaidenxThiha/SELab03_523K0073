using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseRepository
    {
        private readonly Exer3DbContext _context = new Exer3DbContext();

        public void AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.Id == id);
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public void UpdateCourse(Course course)
        {
            var existing = _context.Courses.FirstOrDefault(c => c.Id == course.Id);
            if (existing != null)
            {
                existing.Name = course.Name;
                existing.InstructorId = course.InstructorId;
                _context.SaveChanges();
            }
        }

        public void DeleteCourse(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}
