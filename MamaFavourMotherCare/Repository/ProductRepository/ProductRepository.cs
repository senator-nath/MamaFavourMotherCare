using MamaFavourMotherCare.Data;
using MamaFavourMotherCare.Model;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MamaFavourMotherCare.Repository.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool CreateProduct(Product product)
        {
            _db.Products.Add(product);
            return Save();

        }

        public List<Product> GetAllProduct()
        {
            var allProducts = _db.Products.OrderBy(a => a.ProductName).ToList();
            return allProducts;
        }

        public Product GetProductById(int id)
        {
            var product = _db.Products.FirstOrDefault(a => a.ProductId == id);
            return product;
        }



        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateProduct(Product product, int Id)
        {
            _db.Products.Update(product);
            return Save();
        }

        public bool DeleteProduct(Product product)
        {
            _db.Products.Remove(product);
            return Save();
        }

        public bool ProductExist(int id)
        {
            return _db.Products.Any(product => product.ProductId == id);
        }

        public bool ProductExist(string name)
        {
            return _db.Products.Any(product => product.ProductName == name);
        }
    }
}
