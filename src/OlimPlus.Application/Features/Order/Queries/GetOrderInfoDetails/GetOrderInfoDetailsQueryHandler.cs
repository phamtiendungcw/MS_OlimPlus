using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Order;
using OlimPlus.Application.Exceptions;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.Features.Order.Queries.GetOrderInfoDetails
{
    public class GetOrderInfoDetailsQueryHandler : IRequestHandler<GetOrderInfoDetailsQuery, OrderInfoDetailDto>
    {
        private readonly IOrderInfoRepository _orderInfoRepository;
        private readonly IMapper _mapper;

        public GetOrderInfoDetailsQueryHandler(IOrderInfoRepository orderInfoRepository, IMapper mapper)
        {
            _orderInfoRepository = orderInfoRepository;
            _mapper = mapper;
        }

        public async Task<OrderInfoDetailDto> Handle(GetOrderInfoDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var orderInfo = await _orderInfoRepository.GetByIdAsync(request.Id);

            if (orderInfo is null)
                throw new NotFoundException(nameof(OrderInfo), request.Id);

            var data = _mapper.Map<OrderInfoDetailDto>(orderInfo);

            return data;
        }
    }
}