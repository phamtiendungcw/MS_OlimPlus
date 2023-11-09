using MediatR;
using OlimPlus.Application.DTO.Payment;

namespace OlimPlus.Application.Features.Payment.Queries.GetAllPayments
{
    public record GetAllPaymentsQuery : IRequest<List<PaymentDto>>;
}