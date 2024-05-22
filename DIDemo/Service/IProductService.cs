using DIDemo.Models;

namespace DIDemo.Service
{
    public interface IProductService
    {
        IEnumerable<Products> GetProducts();
        Products GetProductById(int id);
        int AddProduct(Products product);
        int EditProduct(Products product);
        int DeleteProduct(int id);
    }
}
