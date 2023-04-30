using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Table("Reader")]
    public class Reader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReaderId { get; set; }
        [Required(ErrorMessage = "Reader name number required")]

        public string ReaderName { get; set; }
        [Required(ErrorMessage = "Reader gender required")]

        public string ReaderGender { get; set; }
        [Required(ErrorMessage = "Reader address required")]

        public string ReaderAddress { get; set; }
        [Required(ErrorMessage = "Reader phone required")]
        [RegularExpression(@"^(\d{10})?$", ErrorMessage = "Số điện thoại phải đúng 10 số")]
        public string ReaderPhone { get; set; }
        [Required(ErrorMessage = "Reader mail required")]
        [RegularExpression(@"^\w+(\@(gmail)\.)+(com)$", ErrorMessage = "Email sai định dạng")]
        public string ReaderEmail { get; set; }
        public string img { get; set; }
    }
}
