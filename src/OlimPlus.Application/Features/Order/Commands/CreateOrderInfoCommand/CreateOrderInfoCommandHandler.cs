using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.Features.Order.Commands.CreateOrderInfoCommand
{
    public class CreateOrderInfoCommandHandler : IRequestHandler<CreateOrderInfoCommand, int>
    {
        private readonly IOrderInfoRepository _orderInfoRepository;
        private readonly IMapper _mapper;

        public CreateOrderInfoCommandHandler(IOrderInfoRepository orderInfoRepository, IMapper mapper)
        {
            _orderInfoRepository = orderInfoRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateOrderInfoCommand request, CancellationToken cancellationToken)
        {
            var orderInfoToCreate = _mapper.Map<OrderInfo>(request);
            await _orderInfoRepository.CreateAsync(orderInfoToCreate);

            return orderInfoToCreate.Id;
        }
    }
}