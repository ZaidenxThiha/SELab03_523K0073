using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstructorRepository
    {
        private readonly Exer3DbContext _context = new Exer3DbContext();

        public void AddInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors.FirstOrDefault(i => i.Id == id);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _context.Instructors.ToList();
        }

        public void UpdateInstructor(Instructor instructor)
        {
            var existing = _context.Instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (existing != null)
            {
                existing.Name = instructor.Name;
                existing.DepartmentId = instructor.DepartmentId;
                _context.SaveChanges();
            }
        }

        public void DeleteInstructor(int id)
        {
            var instructor = _context.Instructors.FirstOrDefault(i => i.Id == id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                _context.SaveChanges();
            }
        }
    }
}
