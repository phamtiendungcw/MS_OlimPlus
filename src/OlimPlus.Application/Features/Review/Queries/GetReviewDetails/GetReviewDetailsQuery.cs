using MediatR;
using OlimPlus.Application.DTO.Review;

namespace OlimPlus.Application.Features.Review.Queries.GetReviewDetails
{
    public record GetReviewDetailsQuery(int Id) : IRequest<ReviewDetailDto>;
}