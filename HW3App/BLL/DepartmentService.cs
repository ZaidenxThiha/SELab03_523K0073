using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class DepartmentService
    {
        private readonly DepartmentRepository _repository = new DepartmentRepository();

        public void AddDepartment(Department department)
        {
            _repository.AddDepartment(department);
        }

        public Department GetDepartment(int id)
        {
            return _repository.GetDepartmentById(id);
        }

        public List<Department> GetAllDepartments()
        {
            return _repository.GetAllDepartments();
        }

        public void UpdateDepartment(Department department)
        {
            _repository.UpdateDepartment(department);
        }

        public void DeleteDepartment(int id)
        {
            _repository.DeleteDepartment(id);
        }
    }
}