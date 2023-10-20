using MediatR;
using OlimPlus.Application.DTO.Order;

namespace OlimPlus.Application.Features.Order.Queries.GetOrderDetails
{
    public record GetOrderDetailsQuery(int id) : IRequest<OrderDetailDto>;
}
