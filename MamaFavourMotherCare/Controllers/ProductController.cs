using MamaFavourMotherCare.Model.Dtos;
using MamaFavourMotherCare.Service.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MamaFavourMotherCare.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);

        }
        [HttpGet]
        [Route("[controller]/{ProductId:int}"), ActionName("GetProducts")]
        public IActionResult GetProduct([FromRoute] int ProductId)
        {
            var product = _productService.GetProductById(ProductId);
            return Ok(product);
        }

        [HttpPost("Add-Product")]
        public IActionResult CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            var product = _productService.CreateProduct(createProductDto);
            return Ok(product);
        }
        [HttpPut]
        [Route("[controller]/{id:guid}")]
        public IActionResult UpdateProduct([FromBody] UpdateProductDto updateProductDto, [FromRoute] int id)
        {
            var product = _productService.UpdateProduct(updateProductDto, id);
            return Ok(product);
        }
        [HttpDelete]
        [Route("[controller]/{id:guid}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            var product = _productService.GetProductById(id);
            return Ok(product);
        }
    }
}

