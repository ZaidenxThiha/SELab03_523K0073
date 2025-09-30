using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace WinFormUI
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierService _supplierService;

        public SupplierForm()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                Name = txtName.Text,
                ContactEmail = txtContactEmail.Text
            };
            _supplierService.AddSupplier(supplier);
            MessageBox.Show("Supplier added successfully!");
            LoadSuppliers();
        }

        private void btnGetSupplier_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSupplierId.Text, out int supplierId))
            {
                var supplier = _supplierService.GetSupplier(supplierId);
                if (supplier != null)
                {
                    txtName.Text = supplier.Name;
                    txtContactEmail.Text = supplier.ContactEmail;
                }
                else
                {
                    MessageBox.Show("Supplier not found!");
                }
            }
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            dataGridView1.DataSource = suppliers;
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSupplierId.Text, out int supplierId))
            {
                var supplier = new Supplier
                {
                    Id = supplierId,
                    Name = txtName.Text,
                    ContactEmail = txtContactEmail.Text
                };
                _supplierService.UpdateSupplier(supplier);
                MessageBox.Show("Supplier updated successfully!");
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Please enter a valid Supplier ID!");
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSupplierId.Text, out int supplierId))
            {
                _supplierService.DeleteSupplier(supplierId);
                MessageBox.Show("Supplier deleted successfully!");
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Please enter a valid Supplier ID!");
            }
        }


    }
}
