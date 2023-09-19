using AkademiPlusMicroservice.Catalog.Dtos.CategoryDto;
using AkademiPlusMicroservice.Catalog.Dtos.ProductDto;
using AkademiPlusMicroservice.Catalog.Models;
using AutoMapper;

namespace AkademiPlusMicroservice.Catalog.Mapping
{
	public class GenerelMapping :Profile
	{
        public GenerelMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}
