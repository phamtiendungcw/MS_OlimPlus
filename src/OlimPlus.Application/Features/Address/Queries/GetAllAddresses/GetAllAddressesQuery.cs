using MediatR;
using OlimPlus.Application.DTO.Address;

namespace OlimPlus.Application.Features.Address.Queries.GetAllAddresses
{
    public record class GetAllAddressesQuery : IRequest<List<AddressDto>>;
}
