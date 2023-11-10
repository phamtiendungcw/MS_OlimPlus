using AutoMapper;
using OlimPlus.Application.DTO.Address;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<Address, AddressDetailDto>();
        }
    }
}