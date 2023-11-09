using MediatR;
using OlimPlus.Application.DTO.Product;

namespace OlimPlus.Application.Features.Product.Queries.GetProductDetails
{
    public record GetProductDetailsQuery(int Id) : IRequest<ProductDetailDto>;
}