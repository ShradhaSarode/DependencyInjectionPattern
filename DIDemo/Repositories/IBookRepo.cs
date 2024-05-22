using DIDemo.Models;

namespace DIDemo.Repositories
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        int AddBook(Book b);
        int EditBook(Book b);
        int DeleteBook(int id);
    }
}
