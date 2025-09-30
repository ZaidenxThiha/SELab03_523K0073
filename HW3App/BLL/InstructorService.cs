using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class InstructorService
    {
        private readonly InstructorRepository _repository = new InstructorRepository();

        public void AddInstructor(Instructor instructor)
        {
            // Add business logic (e.g., validation)
            if (string.IsNullOrEmpty(instructor.Name))
                throw new ArgumentException("Instructor name is required.");
            _repository.AddInstructor(instructor);
        }

        public Instructor GetInstructor(int id)
        {
            return _repository.GetInstructorById(id);
        }

        public List<Instructor> GetAllInstructors()
        {
            return _repository.GetAllInstructors();
        }

        public void UpdateInstructor(Instructor instructor)
        {
            if (instructor == null || instructor.Id <= 0)
                throw new ArgumentException("Invalid instructor data.");
            _repository.UpdateInstructor(instructor);
        }

        public void DeleteInstructor(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid instructor ID.");
            _repository.DeleteInstructor(id);
        }
    }
}