using MediatR;
using OlimPlus.Application.DTO.Coupon;

namespace OlimPlus.Application.Features.Coupon.Queries.GetCouponDetails
{
    public record class GetCouponDetailsQuery(int Id) : IRequest<CouponDetailDto>;
}