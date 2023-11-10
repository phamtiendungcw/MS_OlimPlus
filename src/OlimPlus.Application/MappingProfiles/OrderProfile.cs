using AutoMapper;
using OlimPlus.Application.DTO.Order;
using OlimPlus.Application.Features.Order.Commands.CreateOrderCommand;
using OlimPlus.Application.Features.Order.Commands.UpdateOrderCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<Order, OrderDetailDto>();
            CreateMap<CreateOrderCommand, Order>();
            CreateMap<UpdateOrderCommand, Order>();
        }
    }
}