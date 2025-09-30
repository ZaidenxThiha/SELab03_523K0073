using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CourseService
    {
        private readonly CourseRepository _repository = new CourseRepository();

        public void AddCourse(Course course)
        {
            if (string.IsNullOrEmpty(course.Name))
                throw new ArgumentException("Course name is required.");
            _repository.AddCourse(course);
        }

        public Course GetCourse(int id)
        {
            return _repository.GetCourseById(id);
        }

        public List<Course> GetAllCourses()
        {
            return _repository.GetAllCourses();
        }

        public void UpdateCourse(Course course)
        {
            if (course == null || course.Id <= 0)
                throw new ArgumentException("Invalid course data.");
            _repository.UpdateCourse(course);
        }

        public void DeleteCourse(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid course ID.");
            _repository.DeleteCourse(id);
        }
    }
}