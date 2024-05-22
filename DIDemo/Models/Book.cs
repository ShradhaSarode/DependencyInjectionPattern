using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIDemo.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public int PageCount { get; set; }
        [Required]
        public string? Language { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
