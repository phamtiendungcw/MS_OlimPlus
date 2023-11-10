using MediatR;
using OlimPlus.Application.DTO.Order;

namespace OlimPlus.Application.Features.Order.Queries.GetAllOrderInfos
{
    public record GetAllOrderInfosQuery : IRequest<List<OrderInfoDto>>;
}