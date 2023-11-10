using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Payment.Commands.DeletePaymentCommand
{
    public class DeletePaymentCommandHandler : IRequestHandler<DeletePaymentCommand, Unit>
    {
        private readonly IPaymentRepository _paymentRepository;

        public DeletePaymentCommandHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<Unit> Handle(DeletePaymentCommand request, CancellationToken cancellationToken)
        {
            var paymentToDelete = await _paymentRepository.GetByIdAsync(request.Id);
            if (paymentToDelete is null)
                throw new NotFoundException(nameof(Domain.Entity.Payment), request.Id);
            await _paymentRepository.DeleteAsync(paymentToDelete);

            return Unit.Value;
        }
    }
}