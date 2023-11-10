using AutoMapper;
using OlimPlus.Application.DTO.Review;
using OlimPlus.Application.Features.Review.Commands.CreateReviewCommand;
using OlimPlus.Application.Features.Review.Commands.UpdateReviewCommand;
using OlimPlus.Domain.Entity;

namespace OlimPlus.Application.MappingProfiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {
            CreateMap<ReviewDto, Review>().ReverseMap();
            CreateMap<Review, ReviewDetailDto>();
            CreateMap<CreateReviewCommand, Review>();
            CreateMap<UpdateReviewCommand, Review>();
        }
    }
}