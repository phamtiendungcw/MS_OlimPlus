using MediatR;
using OlimPlus.Application.DTO.Manufacturer;

namespace OlimPlus.Application.Features.Manufacturer.Queries.GetManufacturerDetails
{
    public record class GetManufacturerDetailsQuery(int Id) : IRequest<ManufacturerDetailDto>;
}