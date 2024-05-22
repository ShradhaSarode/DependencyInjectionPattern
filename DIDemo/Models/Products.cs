using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIDemo.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public int StockQuantity { get; set; }

        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
