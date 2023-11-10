using AutoMapper;
using OlimPlus.Application.DTO.Image;
using OlimPlus.Application.Features.Image.Commands.CreateImageCommand;
using OlimPlus.Application.Features.Image.Commands.UpdateImageCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<ImageDto, Image>().ReverseMap();
            CreateMap<Image, ImageDetailDto>();
            CreateMap<CreateImageCommand, Image>();
            CreateMap<UpdateImageCommand, Image>();
        }
    }
}