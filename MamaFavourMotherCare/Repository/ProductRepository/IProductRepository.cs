using MamaFavourMotherCare.Model;

namespace MamaFavourMotherCare.Repository.ProductRepository
{
    public interface IProductRepository
    {
        List<Product> GetAllProduct();
        Product GetProductById(int id);
        bool CreateProduct(Product product);
        bool UpdateProduct(Product product, int Id);
        bool DeleteProduct(Product product);
        bool ProductExist(int id);
        bool ProductExist(string name);
        bool Save();


    }
}
