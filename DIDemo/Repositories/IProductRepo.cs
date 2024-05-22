using DIDemo.Models;

namespace DIDemo.Repositories
{
    public interface IProductRepo
    {
        IEnumerable<Products> GetProducts();
        Products GetProductById(int id);
        int AddProduct(Products product);
        int EditProduct(Products product);
        int DeleteProduct(int id);
    }
}
