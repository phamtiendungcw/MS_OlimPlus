using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.CartItem.Commands.DeleteCartItemCommand
{
    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand, Unit>
    {
        private readonly ICartItemRepository _cartItemRepository;

        public DeleteCartItemCommandHandler(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<Unit> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {
            var cartItemToDelete = await _cartItemRepository.GetByIdAsync(request.Id);

            if (cartItemToDelete is null)
                throw new NotFoundException(nameof(Domain.Entity.CartItem), request.Id);

            await _cartItemRepository.DeleteAsync(cartItemToDelete);

            return Unit.Value;
        }
    }
}