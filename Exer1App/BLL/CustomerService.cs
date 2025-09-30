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
        private readonly CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void AddCustomer(Customer customer)
        {
            // Add business logic here if needed (e.g., validation)
            _customerRepository.AddCustomer(customer);
        }

        public Customer GetCustomer(int id)
        {
            // Add business logic here if needed
            return _customerRepository.GetCustomerById(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        public void UpdateCustomer(Customer customer)
        {
            // Add business logic here if needed
            _customerRepository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            // Add business logic here if needed
            _customerRepository.DeleteCustomer(id);
        }
    }
}
