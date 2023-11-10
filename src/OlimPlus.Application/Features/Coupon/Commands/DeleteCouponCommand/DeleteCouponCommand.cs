using MediatR;

namespace OlimPlus.Application.Features.Coupon.Commands.DeleteCouponCommand
{
    public class DeleteCouponCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}