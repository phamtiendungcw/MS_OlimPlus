using AutoMapper;
using OlimPlus.Application.DTO.Payment;
using OlimPlus.Application.Features.Payment.Commands.CreatePaymentCommand;
using OlimPlus.Application.Features.Payment.Commands.UpdatePaymentCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentDto, Payment>().ReverseMap();
            CreateMap<Payment, PaymentDetailDto>();
            CreateMap<CreatePaymentCommand, Payment>();
            CreateMap<UpdatePaymentCommand, Payment>();
        }
    }
}