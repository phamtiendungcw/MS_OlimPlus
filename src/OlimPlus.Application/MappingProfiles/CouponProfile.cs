using AutoMapper;
using OlimPlus.Application.DTO.Coupon;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class CouponProfile : Profile
    {
        public CouponProfile()
        {
            CreateMap<CouponDto, Coupon>().ReverseMap();
            CreateMap<Coupon, CouponDetailDto>();
        }
    }
}