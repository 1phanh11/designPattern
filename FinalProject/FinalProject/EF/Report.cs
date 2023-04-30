using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Table("Report")]

    public class Report
    {
        [Key]
        public string ReportID { get; set; }
        public string ReaderID { get; set; }
        public string EmployeeID { get; set; }
        public string DayIssue { get; set; }
        public string Expiration { get; set; }
        public string DayReturn { get; set; }
    }
}
