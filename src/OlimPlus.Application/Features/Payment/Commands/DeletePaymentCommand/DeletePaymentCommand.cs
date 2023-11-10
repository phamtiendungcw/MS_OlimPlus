using MediatR;

namespace OlimPlus.Application.Features.Payment.Commands.DeletePaymentCommand
{
    public class DeletePaymentCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}