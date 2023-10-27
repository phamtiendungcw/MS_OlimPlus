using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Order.Commands.DeleteOrderCommand
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, Unit>
    {
        private readonly IOrderRepository _orderRepository;

        public DeleteOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            var orderToDelete = await _orderRepository.GetByIdAsync(request.Id);

            if (orderToDelete == null)
                throw new NotFoundException(nameof(Domain.Entity.Order), request.Id);

            await _orderRepository.DeleteAsync(orderToDelete);

            return Unit.Value;
        }
    }
}