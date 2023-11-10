using AutoMapper;
using OlimPlus.Application.DTO.Image;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ImageProfile : Profile
    {
        public ImageProfile()
        {
            CreateMap<ImageDto, Image>().ReverseMap();
            CreateMap<Image, ImageDetailDto>();
        }
    }
}