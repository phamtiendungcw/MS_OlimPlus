using AutoMapper;
using OlimPlus.Application.DTO.Coupon;
using OlimPlus.Application.Features.Coupon.Commands.CreateCouponCommand;
using OlimPlus.Application.Features.Coupon.Commands.UpdateCouponCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class CouponProfile : Profile
    {
        public CouponProfile()
        {
            CreateMap<CouponDto, Coupon>().ReverseMap();
            CreateMap<Coupon, CouponDetailDto>();
            CreateMap<CreateCouponCommand, Coupon>();
            CreateMap<UpdateCouponCommand, Coupon>();
        }
    }
}