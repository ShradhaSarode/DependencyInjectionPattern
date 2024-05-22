using DIDemo.Models;
using DIDemo.Repositories;

namespace DIDemo.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo repo;
        public ProductService(IProductRepo repo)
        {
            this.repo = repo;
        }
        public int AddProduct(Products product)
        {
            return repo.AddProduct(product);
        }

        public int DeleteProduct(int id)
        {
            return repo.DeleteProduct(id);
        }

        public int EditProduct(Products product)
        {
            return repo.EditProduct(product);
        }

        public Products GetProductById(int id)
        {
            return repo.GetProductById(id);
        }

        public IEnumerable<Products> GetProducts()
        {
            return repo.GetProducts();
        }

    }
}
