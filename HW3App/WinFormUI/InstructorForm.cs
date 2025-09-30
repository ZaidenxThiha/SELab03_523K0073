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
    public partial class InstructorForm : Form
    {
        private readonly InstructorService _instructorService = new InstructorService();

        public InstructorForm()
        {
            InitializeComponent();
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDepartmentId.Text, out int deptId))
            {
                var instructor = new Instructor
                {
                    Name = txtName.Text,
                    DepartmentId = deptId
                };
                _instructorService.AddInstructor(instructor);
                MessageBox.Show("Instructor added successfully!");
                LoadInstructors();
            }
            else
            {
                MessageBox.Show("Invalid Department ID!");
            }
        }

        private void btnGetInstructor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInstructorId.Text, out int id))
            {
                var instructor = _instructorService.GetInstructor(id);
                if (instructor != null)
                {
                    txtName.Text = instructor.Name;
                    txtDepartmentId.Text = instructor.DepartmentId.ToString();
                }
                else
                {
                    MessageBox.Show("Instructor not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            LoadInstructors();
        }

        private void LoadInstructors()
        {
            var instructors = _instructorService.GetAllInstructors();
            if (instructors != null && instructors.Any())
            {
                var displayData = instructors.Select(i => new
                {
                    i.Id,
                    i.Name,
                    i.DepartmentId
                }).ToList();
                dataGridView1.DataSource = displayData;
               
            }
            else
            {
                MessageBox.Show("No instructors to display.");
                dataGridView1.DataSource = null;
            }
        }

        private void btnUpdateInstructor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInstructorId.Text, out int id) && int.TryParse(txtDepartmentId.Text, out int deptId))
            {
                var instructor = new Instructor
                {
                    Id = id,
                    Name = txtName.Text,
                    DepartmentId = deptId
                };
                _instructorService.UpdateInstructor(instructor);
                MessageBox.Show("Instructor updated successfully!");
                LoadInstructors();
            }
            else
            {
                MessageBox.Show("Invalid ID or Department ID!");
            }
        }

        private void btnDeleteInstructor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInstructorId.Text, out int id))
            {
                _instructorService.DeleteInstructor(id);
                MessageBox.Show("Instructor deleted successfully!");
                LoadInstructors();
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

    }
}
