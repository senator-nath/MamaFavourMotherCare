using AutoMapper;
using MamaFavourMotherCare.Model;
using MamaFavourMotherCare.Model.Dtos;
using MamaFavourMotherCare.Repository.ProductRepository;

namespace MamaFavourMotherCare.Service.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public CreateProductDto CreateProduct(CreateProductDto product)
        {
            var response = new CreateProductDto();
            if (product == null)
            {
                return null;
            }
            if (_productRepository.ProductExist(product.ProductName))
            {
                response.Message = "Product already exist";
                return response;
            }
            var prod = new Product()
            {
                ProductName = product.ProductName,
                Price = product.Price,
                ProductCode = product.ProductCode,
                Description = product.ProductDescription,
                ReleasedDate = product.ReleasedDate,
                CreatedDate = DateTime.Now.ToString("dd-MMMM-yyyy")
            };
            var res = _productRepository.CreateProduct(prod);
            if (res)
            {
                response = new CreateProductDto()
                {
                    ProductName = product.ProductName,
                    Price = product.Price,
                    ProductCode = product.ProductCode,
                    ProductDescription = product.ProductDescription,
                    ReleasedDate = product.ReleasedDate,
                    CreatedDate = DateTime.Now.ToString("dd-MMMM-yyyy")

                };
                return response;
            }
            response.Message = "an error occured";
            return response;
        }

        public DeleteProductDto DeleteProduct(int id)
        {
            var response = new DeleteProductDto();
            if (!_productRepository.ProductExist(id))
            {
                response.Message = "Product does not exist";
                return response;
            }

            var productObj = _productRepository.GetProductById(id);
            if (!_productRepository.DeleteProduct(productObj))
            {
                response.Message = $"Somthing went wrong when deleting the records {productObj.ProductName}";

                return response;
            }
            response.Message = "No content";
            return response;
        }

        public List<ProductDto> GetAllProducts()
        {
            var objList = _productRepository.GetAllProduct();
            var objDto = new List<ProductDto>();

            foreach (var item in objList)
            {
                objDto.Add(_mapper.Map<ProductDto>(item));
            }
            return objDto;
        }

        public ProductDto GetProductById(int id)
        {
            var resp = new ProductDto();
            var obj = _productRepository.GetProductById(id);
            if (obj == null)
            {
                resp.Message = "Incorrect ID";
                return resp;
            }
            var objDto = _mapper.Map<ProductDto>(obj);
            return objDto;
        }

        public UpdateProductDto UpdateProduct(UpdateProductDto product, int id)
        {
            var response = new UpdateProductDto();
            if (product == null || id != Convert.ToInt32(product.ProductId))
            {
                response.Message = "ID does not Match";
                return response;
            }

            var productObj = _mapper.Map<Product>(product);
            if (!_productRepository.UpdateProduct(productObj, id))
            {
                response.Message = $"Somthing went wrong when updating the records {productObj.ProductName}";
                return response;
            }
            response.Message = "No content";
            return response;
        }
    }
}
