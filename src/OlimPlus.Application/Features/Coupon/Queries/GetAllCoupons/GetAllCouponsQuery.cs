using MediatR;
using OlimPlus.Application.DTO.Coupon;

namespace OlimPlus.Application.Features.Coupon.Queries.GetAllCoupons
{
    public record class GetAllCouponsQuery : IRequest<List<CouponDto>>;
}