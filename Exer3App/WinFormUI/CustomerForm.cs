using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormUI
{
    public partial class CustomerForm : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCustomerId;
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnAddCustomer;
        private Button btnGetCustomer;
        private Button btnUpdateCustomer;
        private Button btnDeleteCustomer;
        private DataGridView dataGridView1;
        private Label label4;
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
            LoadCustomers();
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
                LoadCustomers();
            }
            else
            {
                MessageBox.Show("Please enter a valid Customer ID!");
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(415, 111);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 31);
            this.txtCustomerId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(415, 188);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 31);
            this.txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(415, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(675, 112);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(162, 40);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(675, 189);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(162, 42);
            this.btnGetCustomer.TabIndex = 7;
            this.btnGetCustomer.Text = "Get Customer";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(675, 260);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(162, 38);
            this.btnUpdateCustomer.TabIndex = 8;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(895, 112);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(184, 40);
            this.btnDeleteCustomer.TabIndex = 9;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 469);
            this.dataGridView1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Developed by Thiha Aung";
            // 
            // CustomerForm
            // 
            this.ClientSize = new System.Drawing.Size(1311, 818);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
