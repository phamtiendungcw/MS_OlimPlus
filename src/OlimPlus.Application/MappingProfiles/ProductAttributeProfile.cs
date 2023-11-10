using AutoMapper;
using OlimPlus.Application.DTO.Product;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ProductAttributeProfile : Profile
    {
        public ProductAttributeProfile()
        {
            CreateMap<ProductAttributeDto, ProductAttribute>().ReverseMap();
            CreateMap<ProductAttribute, ProductAttributeDetailDto>();
        }
    }
}