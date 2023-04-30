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
    public partial class ViewBookForm : Form
    {
        BookDAO<Book> book = new BookDAOImpl();
        public ViewBookForm()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dgvBook.Rows.Clear();
            foreach (Book b in book.loadBook())
            {

                dgvBook.Rows.Add(b.BookID, b.BookName, b.BookAuthor, book.getGenreName(b.GenreID)
                    , book.getPublishCompanyName(b.PublishID), b.Quantity);

            }
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBook.Columns[e.ColumnIndex].Name;

            if (dgvBook.CurrentRow.Cells[0].Value != null)
            {
                if (colName == "Edit")
                {
                    AddBookForm addBookForm = new AddBookForm();
                    addBookForm.txtBookId.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
                    addBookForm.txtBookName.Text = dgvBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                    addBookForm.txtAuthor.Text = dgvBook.Rows[e.RowIndex].Cells[2].Value.ToString();
                    addBookForm.cbbPublish.Text = dgvBook.Rows[e.RowIndex].Cells[3].Value.ToString();
                    addBookForm.cbbGenre.Text = dgvBook.Rows[e.RowIndex].Cells[4].Value.ToString();

                    addBookForm.txtBookQuantity.Text = dgvBook.Rows[e.RowIndex].Cells[5].Value.ToString();

                    addBookForm.btnAdd.Enabled = false;
                    addBookForm.btnUpdate.Enabled = true;
                    addBookForm.txtBookId.Enabled = true;
                    addBookForm.ShowDialog();
                }
                else if (colName == "Delete")
                {
                    if (MessageBox.Show("Are you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        book.deleteBook((int)dgvBook.CurrentRow.Cells[0].Value);
                    }

                }
            }

            load();
        }

        //private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    dgvBookExp.Rows.Clear();
        //    cmd = new SqlCommand("select  r.ReaderName, rp.Expiration from Books b, Report rp, ReportDetail rd, Reader r where b.BookID = rd.BookID and r.ReaderID = rp.ReaderID and rp.ReportID = rd.ReportID  and rp.DayReturn IS Null and b.BookID =@BookID", con);
        //    cmd.Parameters.AddWithValue("@BookID", dgvBook.CurrentRow.Cells[0].Value.ToString());
        //    con.Open();
        //    reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        dgvBookExp.Rows.Add(reader[0].ToString(), reader[1].ToString());


        //    }
        //    reader.Close();
        //    con.Close();
        //}

        //private void dgvReaderIssue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void dgvBook_CellClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    dgvBookExp.Rows.Clear();
        //    cmd = new SqlCommand("select  r.ReaderName, rp.Expiration from Books b, Report rp, ReportDetail rd, Reader r where b.BookID = rd.BookID and r.ReaderID = rp.ReaderID and rp.ReportID = rd.ReportID  and rp.DayReturn IS Null and b.BookID =@BookID", con);
        //    cmd.Parameters.AddWithValue("@BookID", dgvBook.CurrentRow.Cells[0].Value.ToString());
        //    con.Open();
        //    reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        dgvBookExp.Rows.Add(reader[0].ToString(), reader[1].ToString());


        //    }
        //    reader.Close();
        //    con.Close();
        //}
    }
}
