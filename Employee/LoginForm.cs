using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mappings;
using Model;
using NHibernate;
using NHibernate.Linq;


namespace Employee
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if (UserExistsAndCorrectPassword(username, password))
            {
                MainForm mainForm = new MainForm();
                mainForm.Visible = true;
                this.Visible = false;
            }
            else
            {
                loginStatusLabel.Visible = true;
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private bool UserExistsAndCorrectPassword(string username, string password)
        {
            var session = SessionFactory.CreateSessionFactory().GetCurrentSession();
            var query = from emp in session.Query<Model.Employee>()
                        where emp.Username.ToLower().Equals(username)
                        select emp;

            try
            {
                var employee = query.Single();
                return employee.Password.Equals(password);
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
