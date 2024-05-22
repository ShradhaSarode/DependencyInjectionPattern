using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIDemo.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public decimal Salary { get; set; }

        [ScaffoldColumn(false)]
        public int IsActive { get; set; }

    }
}
