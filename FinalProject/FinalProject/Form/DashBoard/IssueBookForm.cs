using FinalProject.DAO;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class IssueBookForm : Form
    {

        BookDAO<Book> book = BookDAOImpl.Instance;

        ReaderDAO<Reader> reader = ReaderDAOImpl.Instance;

        ReportDAO<Report> report = ReportDAOImpl.Instance;

        public IssueBookForm()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            cbbBookName.DataSource = book.loadBook();
            cbbBookName.DisplayMember = "BookName";
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("This Book will be Issued?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Book has been Issued!");
                    Clear_form();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Clear_form()
        {
            txtBookID.Clear();
            txtRID.Clear();
            txtRPID.Clear();
        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {

            txtReaderName.Text = reader.LoadDataByID(txtRID.Text).ReaderName;

            imgStudent.Image = Image.FromFile(reader.LoadDataByID(txtRID.Text).img);
        }





        private void txtSID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBookID.Text = book.getBookId(cbbBookName.Text).ToString();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Book will be Issued?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                report.createReportDetail(txtRPID.Text, txtRID.Text, txtBookID.Text, txtStatus.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Create new Report?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                report.createReport(txtRPID.Text);
                txtRPID.Enabled = false;

            }
        }
    }
}
