using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        [Required(ErrorMessage = "Book name must not empty.")]

        public string BookName { get; set; }
        [Required(ErrorMessage = "Book author must not empty.")]

        public string BookAuthor { get; set; }

        public string GenreID { get; set; }
        public string PublishID { get; set; }
        [RegularExpression(@"^(?!0)\d+$", ErrorMessage = "Quantity must bigger than 0")]
        public int Quantity { get; set; }
    }
}
