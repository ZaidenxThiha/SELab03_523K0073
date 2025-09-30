using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentRepository
    {
        private readonly Exer3DbContext _context = new Exer3DbContext();

        public void AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public Department GetDepartmentById(int id)
        {
            return _context.Departments.FirstOrDefault(d => d.Id == id);
        }

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

        public void UpdateDepartment(Department department)
        {
            var existing = _context.Departments.FirstOrDefault(d => d.Id == department.Id);
            if (existing != null)
            {
                existing.Name = department.Name;
                _context.SaveChanges();
            }
        }

        public void DeleteDepartment(int id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.Id == id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }
    }
}
