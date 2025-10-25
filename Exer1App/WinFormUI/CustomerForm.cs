using System;
using System.Windows.Forms;
using BLL;
using DAL;

namespace WinFormUI
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerService _customerService;

        public CustomerForm()
        {   
            InitializeComponent();
            _customerService = new CustomerService();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtName.Text,
                Email = txtEmail.Text
            };
            _customerService.AddCustomer(customer);
            MessageBox.Show("Customer added successfully!");
            LoadCustomers(); // Refresh the DataGridView after adding
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCustomerId.Text, out int customerId))
            {
                var customer = _customerService.GetCustomer(customerId);
                if (customer != null)
                {
                    txtName.Text = customer.Name;
                    txtEmail.Text = customer.Email;
                }
                else
                {
                    MessageBox.Show("Customer not found!");
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            dataGridView1.DataSource = customers;
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCustomerId.Text, out int customerId))
            {
                var customer = new Customer
                {
                    Id = customerId,
                    Name = txtName.Text,
                    Email = txtEmail.Text
                };
                _customerService.UpdateCustomer(customer);
                MessageBox.Show("Customer updated successfully!");
                LoadCustomers(); 
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID!");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCustomerId.Text, out int customerId))
            {
                _customerService.DeleteCustomer(customerId);
                MessageBox.Show("Customer deleted successfully!");
                LoadCustomers(); // Refresh the DataGridView after deleting
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID!");
            }
        }
    }
}