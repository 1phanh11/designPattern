using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class ReaderDAOImpl : ReaderDAO<Reader>
    {
        DBHelper db = DBHelper.Instance;

        private static ReaderDAOImpl instance;
        public static ReaderDAOImpl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReaderDAOImpl();
                }
                return instance;
            }
        }
        public void AddReader(string readerName, string readerGender, string readerAddress, string readerPhone, string readerEmail, string readerImage)
        {
            Reader reader = new Reader()
            {
                ReaderName = readerName,
                ReaderGender = readerGender,
                ReaderAddress = readerAddress,
                ReaderPhone = readerPhone,
                ReaderEmail = readerEmail,
                img = readerImage
            };

            ValidationContext context = new ValidationContext(reader, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(reader, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    if (result.MemberNames.FirstOrDefault().Equals("ReaderEmail"))
                    {
                        MessageBox.Show(result.ErrorMessage + "\n" + "format: abc@gmail.com");
                        break;
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorMessage);
                        break;
                    }

                }
            }
            else
            {
                MessageBox.Show("Add success!.");
                db.Readers.Add(reader);
                db.SaveChanges();
            }
        }

        public List<Reader> loadReader()
        {
            return db.Readers.ToList();
        }

        public void delete(int stuId)
        {
            db.Readers.Remove(db.Readers.Find(stuId));
            db.SaveChanges();
        }


        public void update(string readerId, string readerName, string readerGender, string readerAddress, string readerPhone, string readerEmail, string readerImage)
        {
            Reader reader = db.Readers.Find(Convert.ToInt32(readerId));
            reader.ReaderName = readerName;
            reader.ReaderGender = readerGender;
            reader.ReaderAddress = readerAddress;
            reader.ReaderPhone = readerPhone;
            reader.ReaderEmail = readerEmail;
            reader.img = readerImage;

            ValidationContext context = new ValidationContext(reader, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(reader, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    if (result.MemberNames.FirstOrDefault().Equals("ReaderEmail"))
                    {
                        MessageBox.Show(result.ErrorMessage + "\n" + "format: abc@gmail.com");
                        break;
                    }
                    else
                    {
                        MessageBox.Show(result.ErrorMessage);
                        break;
                    }

                }
            }
            else
            {
                MessageBox.Show("update success!.");
                db.SaveChanges();
            }

        }

        public Reader LoadDataByID(string Rid)
        {
            Reader reader = db.Readers.Find(Convert.ToInt32(Rid));
            return reader;
        }


    }
}
