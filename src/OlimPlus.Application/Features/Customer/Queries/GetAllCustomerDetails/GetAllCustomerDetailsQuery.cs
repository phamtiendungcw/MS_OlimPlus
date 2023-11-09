using MediatR;
using OlimPlus.Application.DTO.Customer;

namespace OlimPlus.Application.Features.Customer.Queries.GetAllCustomerDetails
{
    public record class GetAllCustomerDetailsQuery(int Id) : IRequest<CustomerDetailDto>;
}