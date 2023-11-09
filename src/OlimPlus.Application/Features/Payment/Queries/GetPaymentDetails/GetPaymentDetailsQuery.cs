using MediatR;
using OlimPlus.Application.DTO.Payment;

namespace OlimPlus.Application.Features.Payment.Queries.GetPaymentDetails
{
    public record GetPaymentDetailsQuery(int Id) : IRequest<PaymentDetailDto>;
}