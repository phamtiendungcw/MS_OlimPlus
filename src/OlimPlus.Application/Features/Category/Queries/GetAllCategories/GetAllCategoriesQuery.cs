using MediatR;
using OlimPlus.Application.DTO.Category;

namespace OlimPlus.Application.Features.Category.Queries.GetAllCategories
{
    public record GetAllCategoriesQuery : IRequest<List<CategoryDto>>;
}