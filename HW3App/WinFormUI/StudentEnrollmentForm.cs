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
    public partial class StudentEnrollmentForm : Form
    {
        private readonly StudentEnrollmentService _enrollmentService = new StudentEnrollmentService();

        public StudentEnrollmentForm()
        {
            InitializeComponent();
        }

        private void btnAddEnrollment_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int studentId) && int.TryParse(txtCourseId.Text, out int courseId) && DateTime.TryParse(txtEnrollmentDate.Text, out DateTime date))
            {
                var enrollment = new StudentEnrollment
                {
                    StudentId = studentId,
                    CourseId = courseId,
                    EnrollmentDate = date
                };
                _enrollmentService.AddStudentEnrollment(enrollment);
                MessageBox.Show("Enrollment added successfully!");
                LoadEnrollments();
            }
            else
            {
                MessageBox.Show("Invalid Student ID, Course ID, or Enrollment Date!");
            }
        }

        private void btnGetEnrollment_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int studentId) && int.TryParse(txtCourseId.Text, out int courseId))
            {
                var enrollment = _enrollmentService.GetStudentEnrollment(studentId, courseId);
                if (enrollment != null)
                {
                    txtEnrollmentDate.Text = enrollment.EnrollmentDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    MessageBox.Show("Enrollment not found!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Student ID or Course ID!");
            }
        }

        private void StudentEnrollmentForm_Load(object sender, EventArgs e)
        {
            LoadEnrollments();
        }

        private void LoadEnrollments()
        {
            var enrollments = _enrollmentService.GetAllStudentEnrollments();
            if (enrollments != null && enrollments.Any())
            {
                var displayData = enrollments.Select(se => new
                {
                    se.StudentId,
                    se.CourseId,
                    EnrollmentDate = se.EnrollmentDate.ToString("yyyy-MM-dd")
                }).ToList();
                dataGridView1.DataSource = displayData;
            }
            else
            {
                MessageBox.Show("No enrollments to display.");
                dataGridView1.DataSource = null;
            }
        }

        private void btnUpdateEnrollment_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int studentId) && int.TryParse(txtCourseId.Text, out int courseId) && DateTime.TryParse(txtEnrollmentDate.Text, out DateTime date))
            {
                var enrollment = new StudentEnrollment
                {
                    StudentId = studentId,
                    CourseId = courseId,
                    EnrollmentDate = date
                };
                _enrollmentService.UpdateStudentEnrollment(enrollment);
                MessageBox.Show("Enrollment updated successfully!");
                LoadEnrollments();
            }
            else
            {
                MessageBox.Show("Invalid Student ID, Course ID, or Enrollment Date!");
            }
        }

        private void btnDeleteEnrollment_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int studentId) && int.TryParse(txtCourseId.Text, out int courseId))
            {
                _enrollmentService.DeleteStudentEnrollment(studentId, courseId);
                MessageBox.Show("Enrollment deleted successfully!");
                LoadEnrollments();
            }
            else
            {
                MessageBox.Show("Invalid Student ID or Course ID!");
            }
        }

    }
}