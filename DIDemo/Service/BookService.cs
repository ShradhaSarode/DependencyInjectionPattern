using DIDemo.Models;
using DIDemo.Repositories;

namespace DIDemo.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepo repo;
        public BookService(IBookRepo repo)
        {
            this.repo = repo;
        }
        public int AddBook(Book b)
        {
            return repo.AddBook(b);
        }

        public int DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        public int EditBook(Book b)
        {
            return repo.EditBook(b);
        }

        public IEnumerable<Book> GetBook()
        {
            return repo.GetBooks();
        }

        public Book GetBookById(int id)
        {
           return repo.GetBookById(id);
        }
    }
}
