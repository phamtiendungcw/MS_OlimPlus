using MediatR;
using OlimPlus.Application.DTO.Address;

namespace OlimPlus.Application.Features.Address.Queries.GetAddressDetails
{
    public record class GetAddressDetailsQuery(int Id) : IRequest<AddressDetailDto>;
}
