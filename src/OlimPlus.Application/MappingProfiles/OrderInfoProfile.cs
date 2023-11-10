using AutoMapper;
using OlimPlus.Application.DTO.Order;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class OrderInfoProfile : Profile
    {
        public OrderInfoProfile()
        {
            CreateMap<OrderInfoDto, OrderInfo>().ReverseMap();
            CreateMap<OrderInfo, OrderInfoDetailDto>();
        }
    }
}