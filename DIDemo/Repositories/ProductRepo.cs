using DIDemo.Data;
using DIDemo.Models;

namespace DIDemo.Repositories
{
    public class ProductRepo: IProductRepo
    {
        private readonly ApplicationDbContext db;

        public ProductRepo(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddProduct(Products product)
        {
            product.IsActive = 1;
            int result = 0;
            db.Products.Add(product);
            result = db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var model = db.Products.Where(product => product.ProductID == id).FirstOrDefault();
            if (model != null)
            {
                model.IsActive = 0;
                result = db.SaveChanges();
            }
            return result;
        }

        public int EditProduct(Products product)
        {
            int result = 0;
            var model = db.Products.Where(prod => prod.ProductID == product.ProductID).FirstOrDefault();
            if (model != null)
            {
                model.ProductName = product.ProductName;
                model.Price = product.Price;
                model.StockQuantity = product.StockQuantity;
                model.IsActive = 1;
                result = db.SaveChanges();
            }
            return result;
        }

        public Products GetProductById(int id)
        {
            return db.Products.Where(x => x.ProductID == id).SingleOrDefault();
        }

        public IEnumerable<Products> GetProducts()
        {
            var model = (from product in db.Products
                         where product.IsActive == 1
                         select product).ToList();
            return model;
        }
    }
}
