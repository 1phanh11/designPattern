using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Table("PublishCompany")]
    public class PublishCompany
    {
        [Key]
        public string PublishID { get; set; }
        public string PublishName { get; set; }
        public string PublishAddress { get; set; }
        public string PublishPhone { get; set; }
        public string PublishEmail { get; set; }
    }
}
