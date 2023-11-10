using AutoMapper;
using OlimPlus.Application.DTO.Cart;
using OlimPlus.Application.Features.CartItem.Commands.CreateCartItemCommand;
using OlimPlus.Application.Features.CartItem.Commands.UpdateCartItemCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class CartItemProfile : Profile
    {
        public CartItemProfile()
        {
            CreateMap<CartItemDto, CartItem>().ReverseMap();
            CreateMap<CartItem, CartItemDetailDto>();
            CreateMap<CreateCartItemCommand, CartItem>();
            CreateMap<UpdateCartItemCommand, CartItem>();
        }
    }
}