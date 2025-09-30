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
    public partial class DepartmentForm : Form
    {
        private readonly DepartmentService _departmentService = new DepartmentService();

        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            var department = new Department { Name = txtName.Text };
            _departmentService.AddDepartment(department);
            MessageBox.Show("Department added successfully!");
            LoadDepartments();
        }

        private void btnGetDepartment_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDepartmentId.Text, out int id))
            {
                var department = _departmentService.GetDepartment(id);
                if (department != null)
                {
                    txtName.Text = department.Name;
                }
                else
                {
                    MessageBox.Show("Department not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            var departments = _departmentService.GetAllDepartments();
            if (departments != null && departments.Any())
            {
                // Materialize to plain objects or select properties
                var displayData = departments.Select(d => new
                {
                    d.Id,
                    d.Name
                }).ToList();
                dataGridView1.DataSource = displayData;
            
            }
            else
            {
               
                dataGridView1.DataSource = null;
            }
        }

        private void btnUpdateDepartment_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDepartmentId.Text, out int id))
            {
                var department = new Department { Id = id, Name = txtName.Text };
                _departmentService.UpdateDepartment(department);
                MessageBox.Show("Department updated successfully!");
                LoadDepartments();
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDepartmentId.Text, out int id))
            {
                _departmentService.DeleteDepartment(id);
                MessageBox.Show("Department deleted successfully!");
                LoadDepartments();
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }


    }
}
