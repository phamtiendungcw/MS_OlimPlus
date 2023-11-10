using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Order.Commands.DeleteOrderInfoCommand
{
    public class DeleteOrderInfoCommandHandler : IRequestHandler<DeleteOrderInfoCommand, Unit>
    {
        private readonly IOrderInfoRepository _orderInfoRepository;

        public DeleteOrderInfoCommandHandler(IOrderInfoRepository orderInfoRepository)
        {
            _orderInfoRepository = orderInfoRepository;
        }

        public async Task<Unit> Handle(DeleteOrderInfoCommand request, CancellationToken cancellationToken)
        {
            var orderInfoToDelete = await _orderInfoRepository.GetByIdAsync(request.Id);
            if (orderInfoToDelete is null)
                throw new NotFoundException(nameof(Domain.Entity.OrderInfo), request.Id);
            await _orderInfoRepository.DeleteAsync(orderInfoToDelete);

            return Unit.Value;
        }
    }
}