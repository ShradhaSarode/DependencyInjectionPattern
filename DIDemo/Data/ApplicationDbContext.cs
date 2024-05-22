using DIDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DIDemo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<Student> Students { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
