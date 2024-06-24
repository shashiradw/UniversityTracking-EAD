using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.core.Model;
using UniversitySystem.core.Services;

namespace UniversitySystemWFP
{
    public partial class LoginForm : Form
    {
        private IStudentService studentService;
        private User user;

        public LoginForm()
        {
            InitializeComponent();
            user = new User();
            studentService = new StudentService();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            lbl_login_error.Text = "";
            if (String.IsNullOrEmpty(userNameTextBox.Text))
            {
                lbl_login_error.Text = "User name cannot be empty.";
                return;
            }else if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                lbl_login_error.Text = "Password cannot be empty.";
                return;
            }

            user.UserName = userNameTextBox.Text;
            user.Password = passwordTextBox.Text;

            if (studentService.LogIn(user))
            {
                Student student = new Student(user.UserName);
                Hide();
                HomeForm homeForm = new HomeForm(student);
                homeForm.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
