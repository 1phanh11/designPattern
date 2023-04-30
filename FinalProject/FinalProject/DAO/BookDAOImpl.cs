using FinalProject.EF;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FinalProject.DAO
{
    internal class BookDAOImpl : BookDAO<Book>
    {
        DBHelper db = DBHelper.Instance;

        private static BookDAOImpl instance;
        public static BookDAOImpl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookDAOImpl();
                }
                return instance;
            }
        }

        public List<Genre> getGenreList()
        {
            return db.Genres.ToList();
        }

        public List<PublishCompany> getPublishCompanyList()
        {
            return db.PublishCompanys.ToList(); ;
        }

        public void display()
        {

        }

        public void AddBook(string bookName, string author, string genreCode, string publicCode, string quantity)
        {
            Book book = new Book()
            {
                BookName = bookName,
                BookAuthor = author,
                GenreID = genreCode,
                PublishID = publicCode

            };
            int convert = 0;
            if (!string.IsNullOrEmpty(quantity))
            {
                convert = Convert.ToInt32(quantity);
                book.Quantity = convert;
            }

            ValidationContext context = new ValidationContext(book, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(book, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    MessageBox.Show(result.ErrorMessage);
                    break;
                }
            }
            else
            {
                MessageBox.Show("Add success!.");
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public string getGenreId(string genreName)
        {
            string genreId = (from genre in db.Genres
                              where genre.GenreName == genreName
                              select genre.GenreID).FirstOrDefault();
            return genreId;
        }

        public string getPublishCompanyId(string PublishName)
        {
            string publicId = (from publicCompany in db.PublishCompanys
                               where publicCompany.PublishName == PublishName
                               select publicCompany.PublishID).FirstOrDefault();
            return publicId;
        }

        public List<Book> loadBook()
        {
            return db.Books.ToList();
        }


        public void updateBook(string id, string bookName, string bookAuthor, string genreId, string publishId, string quantity)
        {
            int idBook = Convert.ToInt32(id);
            int quantityBook = Convert.ToInt32(quantity);
            Book book = db.Books.Find(idBook);
            int temp = book.Quantity;
            book.Quantity = quantityBook;
            book.BookName = bookName;
            book.BookAuthor = bookAuthor;
            book.GenreID = genreId;
            book.PublishID = publishId;

            ValidationContext context = new ValidationContext(book, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(book, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    MessageBox.Show(result.ErrorMessage);
                    break;
                }
                if (book.Quantity == 0)
                {
                    book.Quantity = temp;
                }
            }
            else
            {
                MessageBox.Show("Book has been successfully updated!");
                db.SaveChanges();
            }

        }

        public void deleteBook(int id)
        {
            db.Books.Remove(db.Books.Find(id));
            db.SaveChanges();
        }

        public string getGenreName(string genreId)
        {
            string genreName = (from genre in db.Genres
                                where genre.GenreID == genreId
                                select genre.GenreName).FirstOrDefault();
            return genreName;
        }

        public string getPublishCompanyName(string publishId)
        {
            string publichName = (from publichC in db.PublishCompanys
                                  where publichC.PublishID == publishId
                                  select publichC.PublishName).FirstOrDefault();
            return publichName;
        }

        public int getBookId(string bookName)
        {
            int bookId = (from b in db.Books
                          where b.BookName == bookName
                          select b.BookID).FirstOrDefault();
            return bookId;
        }
    }
}
