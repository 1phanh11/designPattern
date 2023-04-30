using FinalProject.EF;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public interface BookDAO<T>
    {
        public void AddBook(string bookName, string author, string genreCode, string publicCode, string quantity);
        public List<Genre> getGenreList();
        public List<PublishCompany> getPublishCompanyList();

        public string getGenreId(string genreName);
        public string getPublishCompanyId(string PublishName);

        public string getGenreName(string genreId);
        public string getPublishCompanyName(string publishId);

        public List<Book> loadBook();

        public int getBookId(string bookName);

        public void updateBook(string id, string bookName, string bookAuthor, string genreId,
            string publishId, string quantity);

        public void deleteBook(int id);

    }
}
