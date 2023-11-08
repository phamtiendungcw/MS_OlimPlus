using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Coupon;

namespace OlimPlus.Application.Features.Coupon.Queries.GetAllCoupons
{
    public class GetAllCouponsQueryHandler : IRequestHandler<GetAllCouponsQuery, List<CouponDto>>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public GetAllCouponsQueryHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }

        public async Task<List<CouponDto>> Handle(GetAllCouponsQuery request, CancellationToken cancellationToken)
        {
            var coupons = await _couponRepository.GetAllAsync();
            var data = _mapper.Map<List<CouponDto>>(coupons);

            return data;
        }
    }
}