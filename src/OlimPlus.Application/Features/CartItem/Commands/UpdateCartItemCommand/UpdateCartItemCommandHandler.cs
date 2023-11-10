using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;

namespace OlimPlus.Application.Features.CartItem.Commands.UpdateCartItemCommand
{
    public class UpdateCartItemCommandHandler : IRequestHandler<UpdateCartItemCommand, Unit>
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IMapper _mapper;

        public UpdateCartItemCommandHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCartItemCommand request, CancellationToken cancellationToken)
        {
            var cartItemToUpdate = _mapper.Map<Domain.Entity.CartItem>(request);
            await _cartItemRepository.UpdateAsync(cartItemToUpdate);

            return Unit.Value;
        }
    }
}