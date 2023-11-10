using AutoMapper;
using OlimPlus.Application.DTO.Category;
using OlimPlus.Application.Features.Category.Commands.CreateCategoryCommand;
using OlimPlus.Application.Features.Category.Commands.UpdateCategoryCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<Category, CategoryDetailDto>();
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();
        }
    }
}