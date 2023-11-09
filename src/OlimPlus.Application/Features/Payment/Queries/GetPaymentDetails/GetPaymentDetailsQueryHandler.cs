using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Payment;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Payment.Queries.GetPaymentDetails
{
    public class GetPaymentDetailsQueryHandler : IRequestHandler<GetPaymentDetailsQuery, PaymentDetailDto>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public GetPaymentDetailsQueryHandler(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<PaymentDetailDto> Handle(GetPaymentDetailsQuery request, CancellationToken cancellationToken)
        {
            var payment = await _paymentRepository.GetByIdAsync(request.Id);
            if (payment == null)
                throw new NotFoundException(nameof(Domain.Entity.Payment), request.Id);
            var data = _mapper.Map<PaymentDetailDto>(payment);

            return data;
        }
    }
}