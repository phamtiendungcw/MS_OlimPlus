using MediatR;
using OlimPlus.Application.DTO.Category;

namespace OlimPlus.Application.Features.Category.Queries.GetCategoryDetails
{
    public record GetCategoryDetailsQuery(int Id) : IRequest<CategoryDetailDto>;
}