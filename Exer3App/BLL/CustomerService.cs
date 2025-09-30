using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CustomerService
    {
        private readonly CustomerRepository _repository = new CustomerRepository();

        public void AddCustomer(Customer customer)
        {
            _repository.AddCustomer(customer);
        }

        public Customer GetCustomer(int id)
        {
            return _repository.GetCustomerById(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _repository.GetAllCustomers();
        }

        public void UpdateCustomer(Customer customer)
        {
            _repository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _repository.DeleteCustomer(id);
        }
    }
}