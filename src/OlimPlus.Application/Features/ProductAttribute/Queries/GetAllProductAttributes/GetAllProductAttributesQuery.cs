using MediatR;
using OlimPlus.Application.DTO.Product;

namespace OlimPlus.Application.Features.ProductAttribute.Queries.GetAllProductAttributes
{
    public record GetAllProductAttributesQuery : IRequest<List<ProductAttributeDto>>;
}