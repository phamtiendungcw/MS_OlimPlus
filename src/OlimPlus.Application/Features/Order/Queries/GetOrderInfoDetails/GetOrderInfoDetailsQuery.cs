using MediatR;
using OlimPlus.Application.DTO.Order;

namespace OlimPlus.Application.Features.Order.Queries.GetOrderInfoDetails
{
    public record GetOrderInfoDetailsQuery(int Id) : IRequest<OrderInfoDetailDto>;
}