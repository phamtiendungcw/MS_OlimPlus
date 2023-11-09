using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Cart;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.CartItem.Queries.GetCartItemDetails
{
    public class GetCartItemDetailsQueryHandler : IRequestHandler<GetCartItemDetailsQuery, CartItemDetailDto>
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IMapper _mapper;

        public GetCartItemDetailsQueryHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<CartItemDetailDto> Handle(GetCartItemDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var cartItem = await _cartItemRepository.GetByIdAsync(request.Id);

            if (cartItem == null)
                throw new NotFoundException(nameof(Domain.Entity.CartItem), request.Id);

            var data = _mapper.Map<CartItemDetailDto>(cartItem);

            return data;
        }
    }
}