using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DepartmentForm().ShowDialog();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new InstructorForm().ShowDialog();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CourseForm().ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudentForm().ShowDialog();
        }

        private void studentEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StudentEnrollmentForm().ShowDialog();
        }

    }
}
