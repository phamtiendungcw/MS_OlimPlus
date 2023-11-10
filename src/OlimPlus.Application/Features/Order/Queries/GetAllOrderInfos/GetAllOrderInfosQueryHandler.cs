using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Order;

namespace OlimPlus.Application.Features.Order.Queries.GetAllOrderInfos
{
    public class GetAllOrderInfosQueryHandler : IRequestHandler<GetAllOrderInfosQuery, List<OrderInfoDto>>
    {
        private readonly IOrderInfoRepository _orderInfoRepository;
        private readonly IMapper _mapper;

        public GetAllOrderInfosQueryHandler(IOrderInfoRepository orderInfoRepository, IMapper mapper)
        {
            _orderInfoRepository = orderInfoRepository;
            _mapper = mapper;
        }

        public async Task<List<OrderInfoDto>> Handle(GetAllOrderInfosQuery request, CancellationToken cancellationToken)
        {
            var orderInfos = await _orderInfoRepository.GetAllAsync();
            var data = _mapper.Map<List<OrderInfoDto>>(orderInfos);

            return data;
        }
    }
}