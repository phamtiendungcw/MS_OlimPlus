using AutoMapper;
using OlimPlus.Application.DTO.Customer;
using OlimPlus.Application.Features.Customer.Commands.CreateCustomerCommand;
using OlimPlus.Application.Features.Customer.Commands.UpdateCustomerCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<Customer, CustomerDetailDto>();
            CreateMap<CreateCustomerCommand, Customer>();
            CreateMap<UpdateCustomerCommand, Customer>();
        }
    }
}