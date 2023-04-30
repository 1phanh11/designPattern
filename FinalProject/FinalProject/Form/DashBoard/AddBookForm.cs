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

    public partial class AddBookForm : Form
    {

        BookDAO<Book> book = BookDAOImpl.Instance;

        public AddBookForm()
        {
            InitializeComponent();
            cbbGenre.DataSource = book.getGenreList();
            cbbPublish.DataSource = book.getPublishCompanyList();
            cbbGenre.DisplayMember = "GenreName";
            cbbPublish.DisplayMember = "PublishName";
            loadId();
        }

        private void loadId()
        {
            txtPCode.Text = book.getPublishCompanyId(cbbPublish.Text);
            txtGCOde.Text = book.getGenreId(cbbGenre.Text);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to save this Book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                book.AddBook(txtBookName.Text, txtAuthor.Text, txtGCOde.Text, txtPCode.Text, txtBookQuantity.Text);
            }
            if (MessageBox.Show("Are you want to clear form", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clear_Form();
            }
        }
        private void Clear_Form()
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtBookQuantity.Clear();
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
            if (MessageBox.Show("Are you want to update this book?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                book.updateBook(txtBookId.Text, txtBookName.Text, txtAuthor.Text, txtGCOde.Text, txtPCode.Text, txtBookQuantity.Text);
                this.Dispose();
            }


        }



        private void cbbPublish_SelectedIndexChanged(object sender, EventArgs e)
        {
            string publicCode = book.getPublishCompanyId(cbbPublish.Text);
            txtPCode.Text = publicCode;
        }

        private void cbbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genreCode = book.getGenreId(cbbGenre.Text);
            txtGCOde.Text = genreCode;

        }


    }
}
