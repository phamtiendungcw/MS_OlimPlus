using MediatR;
using OlimPlus.Application.DTO.Product;

namespace OlimPlus.Application.Features.Product.Queries.GetAllProductAttributes
{
    public record GetAllProductAttributesQuery : IRequest<List<ProductAttributeDto>>;
}