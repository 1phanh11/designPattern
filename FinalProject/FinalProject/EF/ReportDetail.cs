using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Table("ReportDetail")]
    public class ReportDetail
    {
        [Key]
        public string ReportID { get; set; }
        public string BookID { get; set; }
        public string ReaderID { get; set; }
        public string Status { get; set; }
    }
}
