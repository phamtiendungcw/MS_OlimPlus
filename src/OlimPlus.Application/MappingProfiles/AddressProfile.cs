using AutoMapper;
using OlimPlus.Application.DTO.Address;
using OlimPlus.Application.Features.Address.Commands.CreateAddressCommand;
using OlimPlus.Application.Features.Address.Commands.UpdateAddressCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<Address, AddressDetailDto>();
            CreateMap<CreateAddressCommand, Address>();
            CreateMap<UpdateAddressCommand, Address>();
        }
    }
}