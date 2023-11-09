using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Payment.Commands.CreatePaymentCommand
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, int>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public CreatePaymentCommandHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            var paymentToCreate = _mapper.Map<Domain.Entity.Payment>(request);
            await _paymentRepository.CreateAsync(paymentToCreate);

            return paymentToCreate.Id;
        }
    }
}