using MediatR;
using OlimPlus.Application.DTO.Cart;

namespace OlimPlus.Application.Features.CartItem.Queries.GetAllCartItems
{
    public record class GetAllCartItemsQuery : IRequest<List<CartItemDto>>;
}