using MediatR;
using OlimPlus.Application.DTO.Manufacturer;

namespace OlimPlus.Application.Features.Manufacturer.Queries.GetAllManufacturers
{
    public record class GetAllManufacturersQuery : IRequest<List<ManufacturerDto>>;
}