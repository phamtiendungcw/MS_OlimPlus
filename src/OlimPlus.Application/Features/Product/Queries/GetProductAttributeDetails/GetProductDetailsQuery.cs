using MediatR;
using OlimPlus.Application.DTO.Product;

namespace OlimPlus.Application.Features.Product.Queries.GetProductAttributeDetails
{
    public record GetProductDetailsQuery(int Id) : IRequest<ProductAttributeDetailDto>;
}