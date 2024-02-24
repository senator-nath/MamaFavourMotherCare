using AutoMapper;
using MamaFavourMotherCare.Model;
using MamaFavourMotherCare.Model.Dtos;

namespace MamaFavourMotherCare.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, DeleteProductDto>().ReverseMap();


        }

    }
}
