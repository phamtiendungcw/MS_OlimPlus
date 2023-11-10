using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Cart;

namespace OlimPlus.Application.Features.CartItem.Queries.GetAllCartItems
{
    public class GetAllCartItemsQueryHandler : IRequestHandler<GetAllCartItemsQuery, List<CartItemDto>>
    {
        private readonly ICartItemRepository _cartItemRepository;
        private readonly IMapper _mapper;

        public GetAllCartItemsQueryHandler(ICartItemRepository cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<List<CartItemDto>> Handle(GetAllCartItemsQuery request, CancellationToken cancellationToken)
        {
            var cartItems = await _cartItemRepository.GetAllAsync();
            var data = _mapper.Map<List<CartItemDto>>(cartItems);

            return data;
        }
    }
}