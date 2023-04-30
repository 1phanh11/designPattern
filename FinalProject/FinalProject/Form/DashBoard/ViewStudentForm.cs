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
    public partial class ViewStudentForm : Form
    {
        ReaderDAO<Reader> reader = ReaderDAOImpl.Instance;

        public ViewStudentForm()
        {
            InitializeComponent();
            LoadStudent();
        }
        public void LoadStudent()
        {

            dgvStudent.Rows.Clear();
            foreach (Reader r in reader.loadReader())
            {

                dgvStudent.Rows.Add(r.ReaderId, r.ReaderName, r.ReaderGender,
                    r.ReaderAddress, r.ReaderPhone, r.ReaderEmail, Bitmap.FromFile(r.img));
            }
        }



        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void dgvStudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStudent.Columns[e.ColumnIndex].Name;
            if (dgvStudent.CurrentRow.Cells[0].Value != null)
            {
                if (colName == "Edit")
                {
                    AddStudentForm addStudentForm = new AddStudentForm();
                    addStudentForm.txtIdReader.Text = dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString();
                    addStudentForm.txtStudentName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].Value.ToString();
                    addStudentForm.cbbGender.Text = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString();
                    addStudentForm.txtAddress.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                    addStudentForm.txtStudentPhone.Text = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                    addStudentForm.txtStudentEmail.Text = dgvStudent.Rows[e.RowIndex].Cells[5].Value.ToString();
                    addStudentForm.imgStudent.Image = (Image)dgvStudent.Rows[e.RowIndex].Cells[6].Value;

                    addStudentForm.btnAdd.Enabled = false;
                    addStudentForm.btnUpdate.Enabled = true;
                    addStudentForm.ShowDialog();
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Are you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        reader.delete((int)dgvStudent.CurrentRow.Cells[0].Value);
                    }

                }
            }

            LoadStudent();
        }
    }
}
