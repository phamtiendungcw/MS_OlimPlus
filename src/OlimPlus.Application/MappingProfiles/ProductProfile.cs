using AutoMapper;
using OlimPlus.Application.DTO.Product;
using OlimPlus.Application.Features.Product.Commands.CreateProductCommand;
using OlimPlus.Application.Features.Product.Commands.UpdateProductCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<Product, ProductDetailDto>();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();
        }
    }
}