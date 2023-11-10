using AutoMapper;
using OlimPlus.Application.DTO.Manufacturer;
using OlimPlus.Application.Features.Manufacturer.Commands.CreateManufacturerCommand;
using OlimPlus.Application.Features.Manufacturer.Commands.UpdateManufacturerCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ManufacturerProfile : Profile
    {
        public ManufacturerProfile()
        {
            CreateMap<ManufacturerDto, Manufacturer>().ReverseMap();
            CreateMap<Manufacturer, ManufacturerDetailDto>();
            CreateMap<CreateManufacturerCommand, Manufacturer>();
            CreateMap<UpdateManufacturerCommand, Manufacturer>();
        }
    }
}