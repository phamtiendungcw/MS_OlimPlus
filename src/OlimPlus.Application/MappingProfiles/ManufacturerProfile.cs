using AutoMapper;
using OlimPlus.Application.DTO.Manufacturer;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ManufacturerProfile : Profile
    {
        public ManufacturerProfile()
        {
            CreateMap<ManufacturerDto, Manufacturer>().ReverseMap();
            CreateMap<Manufacturer, ManufacturerDetailDto>();
        }
    }
}