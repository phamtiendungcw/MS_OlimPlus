using MediatR;
using OlimPlus.Application.DTO.Cart;

namespace OlimPlus.Application.Features.CartItem.Queries.GetCartItemDetails
{
    public record class GetCartItemDetailsQuery(int Id) : IRequest<CartItemDetailDto>;
}