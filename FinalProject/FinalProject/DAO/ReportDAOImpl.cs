using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class ReportDAOImpl : ReportDAO<Report>
    {
        DBHelper db = DBHelper.Instance;

        private static ReportDAOImpl instance;
        public static ReportDAOImpl Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReportDAOImpl();
                }
                return instance;
            }
        }

        public void createReportDetail(string RPid, string Rid, string Bid, string status)
        {
            ReportDetail rpd = new ReportDetail()
            {
                ReportID = RPid,
                ReaderID = Rid,
                Status = status,
                BookID = Bid

            };

            ValidationContext context = new ValidationContext(rpd, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(rpd, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {

                    MessageBox.Show(result.ErrorMessage + "\n" + "format: abc@gmail.com");
                    break;

                }
            }
            else
            {
                MessageBox.Show("Add success!.");
                db.ReportDetails.Add(rpd);
                db.SaveChanges();
            }
        }

        public void createReport(string RPid)
        {
            db.Reports.Add(new Report() { ReportID = RPid });
            db.SaveChanges();
        }
    }
}
