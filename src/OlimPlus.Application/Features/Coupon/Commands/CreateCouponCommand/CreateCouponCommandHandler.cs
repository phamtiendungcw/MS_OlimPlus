using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Coupon.Commands.CreateCouponCommand
{
    public class CreateCouponCommandHandler : IRequestHandler<CreateCouponCommand, int>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public CreateCouponCommandHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCouponCommand request, CancellationToken cancellationToken)
        {
            var couponToCreate = _mapper.Map<Domain.Entity.Coupon>(request);
            await _couponRepository.CreateAsync(couponToCreate);

            return couponToCreate.Id;
        }
    }
}