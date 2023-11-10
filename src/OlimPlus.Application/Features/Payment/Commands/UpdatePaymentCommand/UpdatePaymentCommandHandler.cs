using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Payment.Commands.UpdatePaymentCommand
{
    public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand, Unit>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public UpdatePaymentCommandHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
        {
            var paymentToUpdate = _mapper.Map<Domain.Entity.Payment>(request);
            await _paymentRepository.UpdateAsync(paymentToUpdate);

            return Unit.Value;
        }
    }
}