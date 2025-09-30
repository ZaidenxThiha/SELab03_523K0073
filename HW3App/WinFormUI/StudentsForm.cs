using BLL;
using DAL;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormUI
{
    public partial class StudentForm : Form
    {
        private readonly StudentService _studentService = new StudentService();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDepartmentId.Text, out int deptId))
            {
                var student = new Student
                {
                    Name = txtName.Text,
                    DepartmentId = deptId
                };
                _studentService.AddStudent(student);
                MessageBox.Show("Student added successfully!");
                LoadStudents();
            }
            else
            {
                MessageBox.Show("Invalid Department ID!");
            }
        }

        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int id))
            {
                var student = _studentService.GetStudent(id);
                if (student != null)
                {
                    txtName.Text = student.Name;
                    txtDepartmentId.Text = student.DepartmentId.ToString();
                }
                else
                {
                    MessageBox.Show("Student not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            var students = _studentService.GetAllStudents();
            if (students != null && students.Any())
            {
                var displayData = students.Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.DepartmentId
                }).ToList();
                dataGridView1.DataSource = displayData;
               
            }
            else
            {
                
                dataGridView1.DataSource = null;
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int id) && int.TryParse(txtDepartmentId.Text, out int deptId))
            {
                var student = new Student
                {
                    Id = id,
                    Name = txtName.Text,
                    DepartmentId = deptId
                };
                _studentService.UpdateStudent(student);
                MessageBox.Show("Student updated successfully!");
                LoadStudents();
            }
            else
            {
                MessageBox.Show("Invalid ID or Department ID!");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int id))
            {
                _studentService.DeleteStudent(id);
                MessageBox.Show("Student deleted successfully!");
                LoadStudents();
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

    }
}
