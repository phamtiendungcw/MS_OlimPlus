using AutoMapper;
using OlimPlus.Application.DTO.Review;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<ReviewDto, Review>().ReverseMap();
            CreateMap<Review, ReviewDetailDto>();
        }
    }
}