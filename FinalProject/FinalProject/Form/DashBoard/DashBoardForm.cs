using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm ab = new AddBookForm();
            ab.btnUpdate.Enabled = false;
            ab.Show();
        }



        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}

        //private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddBookForm ab = new AddBookForm();
        //    ab.btnUpdate.Enabled = false;
        //    ab.Show();

        //}
        //private Form activeForm = null;
        //private void openChildForm(Form childForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    paneDashboard.Controls.Add(childForm);
        //    paneDashboard.Tag = childForm;  
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookForm viewBookForm = new ViewBookForm();
            viewBookForm.ShowDialog();
        }

        private void bookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBookForm bookForm = new IssueBookForm();
            bookForm.ShowDialog();
        }



        //private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddStudentForm ab = new AddStudentForm();
        //    ab.btnUpdate.Enabled=false;
        //    ab.Show();
        //}

        //private void viewStudentInforToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new ViewStudentForm());
        //}

        //private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void bookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    IssueBookForm ib = new IssueBookForm();
        //    ib.Show();
        //}

        //private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ReturnBookForm rb = new ReturnBookForm();
        //    rb.Show();
        //}

        //private void bookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new ViewIssueForm());
        //}

        //private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    AddCategoryForm ab = new AddCategoryForm();
        //    ab.Show();
        //}

        //private void manageEmployeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new EmployeeViewForm());
        //}
    }
}
