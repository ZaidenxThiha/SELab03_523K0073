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
    public partial class CourseForm : Form
    {
        private readonly CourseService _courseService = new CourseService();

        public CourseForm()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInstructorId.Text, out int instructorId))
            {
                var course = new Course
                {
                    Name = txtName.Text,
                    InstructorId = instructorId
                };
                _courseService.AddCourse(course);
                MessageBox.Show("Course added successfully!");
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Invalid Instructor ID!");
            }
        }

        private void btnGetCourse_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCourseId.Text, out int id))
            {
                var course = _courseService.GetCourse(id);
                if (course != null)
                {
                    txtName.Text = course.Name;
                    txtInstructorId.Text = course.InstructorId.ToString();
                }
                else
                {
                    MessageBox.Show("Course not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = _courseService.GetAllCourses();
            if (courses != null && courses.Any())
            {
                var displayData = courses.Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.InstructorId
                }).ToList();
                dataGridView1.DataSource = displayData;
               
            }
            else
            {
                
                dataGridView1.DataSource = null;
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCourseId.Text, out int id) && int.TryParse(txtInstructorId.Text, out int instructorId))
            {
                var course = new Course
                {
                    Id = id,
                    Name = txtName.Text,
                    InstructorId = instructorId
                };
                _courseService.UpdateCourse(course);
                MessageBox.Show("Course updated successfully!");
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Invalid ID or Instructor ID!");
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCourseId.Text, out int id))
            {
                _courseService.DeleteCourse(id);
                MessageBox.Show("Course deleted successfully!");
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

    }
}
