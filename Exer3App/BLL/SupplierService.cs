using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SupplierService
    {
        private readonly SupplierRepository _repository = new SupplierRepository();

        public void AddSupplier(Supplier supplier)
        {
            _repository.AddSupplier(supplier);
        }

        public Supplier GetSupplier(int id)
        {
            return _repository.GetSupplierById(id);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _repository.GetAllSuppliers();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _repository.UpdateSupplier(supplier);
        }

        public void DeleteSupplier(int id)
        {
            _repository.DeleteSupplier(id);
        }
    }
}
