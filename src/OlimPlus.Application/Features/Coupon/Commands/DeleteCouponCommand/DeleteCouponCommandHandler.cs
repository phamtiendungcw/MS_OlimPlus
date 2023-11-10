using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Coupon.Commands.DeleteCouponCommand
{
    public class DeleteCouponCommandHandler : IRequestHandler<DeleteCouponCommand, Unit>
    {
        private readonly ICouponRepository _couponRepository;

        public DeleteCouponCommandHandler(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        public async Task<Unit> Handle(DeleteCouponCommand request, CancellationToken cancellationToken)
        {
            var couponToDelete = await _couponRepository.GetByIdAsync(request.Id);

            if (couponToDelete is null)
                throw new NotFoundException(nameof(Domain.Entity.Coupon), request.Id);

            await _couponRepository.DeleteAsync(couponToDelete);

            return Unit.Value;
        }
    }
}