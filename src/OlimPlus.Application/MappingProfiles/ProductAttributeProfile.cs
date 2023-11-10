using AutoMapper;
using OlimPlus.Application.DTO.Product;
using OlimPlus.Application.Features.Product.Commands.CreateProductAttributeCommand;
using OlimPlus.Application.Features.Product.Commands.UpdateProductAttributeCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ProductAttributeProfile : Profile
    {
        public ProductAttributeProfile()
        {
            CreateMap<ProductAttributeDto, ProductAttribute>().ReverseMap();
            CreateMap<ProductAttribute, ProductAttributeDetailDto>();
            CreateMap<CreateProductAttributeCommand, ProductAttribute>();
            CreateMap<UpdateProductAttributeCommand, ProductAttribute>();
        }
    }
}