using AutoMapper;
using OlimPlus.Application.DTO.Cart;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class CartItemProfile : Profile
    {
        public CartItemProfile()
        {
            CreateMap<CartItemDto, CartItem>().ReverseMap();
            CreateMap<CartItem, CartItemDetailDto>();
        }
    }
}