using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Coupon;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Coupon.Queries.GetCouponDetails
{
    public class GetCouponDetailsQueryHandler : IRequestHandler<GetCouponDetailsQuery, CouponDetailDto>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public GetCouponDetailsQueryHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }

        public async Task<CouponDetailDto> Handle(GetCouponDetailsQuery request, CancellationToken cancellationToken)
        {
            var coupon = await _couponRepository.GetByIdAsync(request.Id);

            if (coupon == null)
                throw new NotFoundException(nameof(Domain.Entity.Coupon), request.Id);

            var data = _mapper.Map<CouponDetailDto>(coupon);

            return data;
        }
    }
}