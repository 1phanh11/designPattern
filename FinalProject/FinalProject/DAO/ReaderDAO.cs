using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public interface ReaderDAO<T>
    {
        public void AddReader(string readerName, string readerGender, string readerAddress, string readerPhone, string readerEmail, string readerImage);

        public List<T> loadReader();

        public void delete(int stuId);
        public void update(string readerId, string readerName, string readerGender, string readerAddress, string readerPhone, string readerEmail, string readerImage);
        public Reader LoadDataByID(string Rid);

    }
}
