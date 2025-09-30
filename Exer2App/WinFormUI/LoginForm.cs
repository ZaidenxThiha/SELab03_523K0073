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
namespace WinFormUI
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_userService.ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                // Optionally, open main form here in Exercise 3
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
