using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.Features.Order.Commands.UpdateOrderInfoCommand
{
    public class UpdateOrderInfoCommandHandler : IRequestHandler<UpdateOrderInfoCommand, Unit>
    {
        private readonly IOrderInfoRepository _orderInfoRepository;
        private readonly IMapper _mapper;

        public UpdateOrderInfoCommandHandler(IOrderInfoRepository orderInfoRepository, IMapper mapper)
        {
            _orderInfoRepository = orderInfoRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateOrderInfoCommand request, CancellationToken cancellationToken)
        {
            var orderInfoToUpdate = _mapper.Map<OrderInfo>(request);
            await _orderInfoRepository.UpdateAsync(orderInfoToUpdate);

            return Unit.Value;
        }
    }
}