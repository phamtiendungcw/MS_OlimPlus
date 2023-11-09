using MediatR;
using OlimPlus.Application.DTO.Product;

namespace OlimPlus.Application.Features.ProductAttribute.Queries.GetProductDetails
{
    public record GetProductDetailsQuery(int Id) : IRequest<ProductAttributeDetailDto>;
}