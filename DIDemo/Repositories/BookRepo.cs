using DIDemo.Data;
using DIDemo.Models;

namespace DIDemo.Repositories
{
    public class BookRepo : IBookRepo
    {
        private readonly ApplicationDbContext db;
        public BookRepo(ApplicationDbContext d)
        {
            this.db = d;
        }
        public int AddBook(Book b)
        {
            b.IsActive = 1;
            int result = 0;
            db.Books.Add(b);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteBook(int id)
        {
            int result = 0;
            var model = db.Books.Where(b => b.BookID == id).FirstOrDefault();
            if (model != null)
            {
                model.IsActive = 0;
                result = db.SaveChanges();
            }
            return result;
        }

        public int EditBook(Book b)
        {
            int result = 0;
            var model = db.Books.Where(bk => bk.BookID == b.BookID).FirstOrDefault();
            if (model != null)
            {
                model.Name = b.Name;
                model.Author = b.Author;
                model.PageCount = b.PageCount;
                model.Language = b.Language;
                model.Price = b.Price;
                model.IsActive = 1;
                result = db.SaveChanges();
            }
            return result;
        }

        public Book GetBookById(int id)
        {
            return db.Books.Where(b => b.BookID == id).SingleOrDefault();
            //var res = (from b in db.Books
            //            where b.BookID == id 
            //            select b).FirstOrDefault();
            //return res;

        }

        public IEnumerable<Book> GetBooks()
        {
            var model = (from b in db.Books
                         where b.IsActive == 1
                         select b).ToList();
            return model;
        }

       
    }
}
