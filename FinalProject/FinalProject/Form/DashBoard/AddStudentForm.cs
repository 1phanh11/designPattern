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
    public partial class AddStudentForm : Form
    {
        ReaderDAO<Reader> reader = ReaderDAOImpl.Instance;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public AddStudentForm()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to save this reader?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader.AddReader(txtStudentName.Text, cbbGender.Text, txtAddress.Text, txtStudentPhone.Text, txtStudentEmail.Text, openFileDialog.FileName);
            }
            if (MessageBox.Show("Are you want to clear form", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clear_Form();
            }
        }
        private void Clear_Form()
        {
            txtStudentName.Clear();
            txtAddress.Clear();
            txtStudentPhone.Clear();
            txtStudentEmail.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your Data is not saved!", "Are you want to cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to update this reader?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                reader.update(txtIdReader.Text, txtStudentName.Text, cbbGender.Text, txtAddress.Text, txtStudentPhone.Text, txtStudentEmail.Text, openFileDialog.FileName);
                this.Dispose();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Select imgae(*.Jpg, *.png, *.Gif)|*.Jpg;*.png;*.Gif ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgStudent.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
