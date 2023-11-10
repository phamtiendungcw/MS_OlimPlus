using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Order;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Order.Queries.GetOrderDetails
{
    public class GetOrderDetailsQueryHandler : IRequestHandler<GetOrderDetailsQuery, OrderDetailDto>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public GetOrderDetailsQueryHandler(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<OrderDetailDto> Handle(GetOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByIdAsync(request.id);

            if (order == null)
                throw new NotFoundException(nameof(Domain.Entity.Order), request.id);

            var data = _mapper.Map<OrderDetailDto>(order);

            return data;
        }
    }
}