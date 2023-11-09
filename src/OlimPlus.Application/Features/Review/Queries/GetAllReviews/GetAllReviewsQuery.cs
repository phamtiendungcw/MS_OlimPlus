using MediatR;
using OlimPlus.Application.DTO.Review;

namespace OlimPlus.Application.Features.Review.Queries.GetAllReviews
{
    public record GetAllReviewsQuery : IRequest<List<ReviewDto>>;
}