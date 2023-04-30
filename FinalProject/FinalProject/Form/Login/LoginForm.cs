using FinalProject.DAO;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class LoginForm : Form
    {
        private IUser _user;

        public LoginForm()
        {
            InitializeComponent();
            _user = UserFactory.CreateUser("sql");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_user.Authenticate(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("WelCome", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DashBoardForm dashBoardForm = new DashBoardForm();
                dashBoardForm.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
