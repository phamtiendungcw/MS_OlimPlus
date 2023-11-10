using AutoMapper;
using OlimPlus.Application.DTO.Order;
using OlimPlus.Application.Features.Order.Commands.CreateOrderInfoCommand;
using OlimPlus.Application.Features.Order.Commands.UpdateOrderInfoCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class OrderInfoProfile : Profile
    {
        public OrderInfoProfile()
        {
            CreateMap<OrderInfoDto, OrderInfo>().ReverseMap();
            CreateMap<OrderInfo, OrderInfoDetailDto>();
            CreateMap<CreateOrderInfoCommand, OrderInfo>();
            CreateMap<UpdateOrderInfoCommand, OrderInfo>();
        }
    }
}