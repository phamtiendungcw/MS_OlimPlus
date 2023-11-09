using MediatR;
using OlimPlus.Application.DTO.Customer;

namespace OlimPlus.Application.Features.Customer.Queries.GetAllCustomers
{
    public record class GetAllCustomersQuery : IRequest<List<CustomerDto>>;
}