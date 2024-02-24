using MamaFavourMotherCare.Model.Dtos;

namespace MamaFavourMotherCare.Service.ProductService
{
    public interface IProductService
    {
        List<ProductDto> GetAllProducts();
        ProductDto GetProductById(int id);
        CreateProductDto CreateProduct(CreateProductDto product);
        UpdateProductDto UpdateProduct(UpdateProductDto product, int id);
        DeleteProductDto DeleteProduct(int id);

    }
}
