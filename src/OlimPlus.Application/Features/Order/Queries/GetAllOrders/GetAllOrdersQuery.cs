using MediatR;
using OlimPlus.Application.DTO.Order;

namespace OlimPlus.Application.Features.Order.Queries.GetAllOrders
{
    public record GetAllOrdersQuery : IRequest<List<OrderDto>>;
}