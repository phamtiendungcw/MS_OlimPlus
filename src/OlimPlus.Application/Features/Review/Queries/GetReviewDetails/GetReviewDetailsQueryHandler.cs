using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Review;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Review.Queries.GetReviewDetails
{
    public class GetReviewDetailsQueryHandler : IRequestHandler<GetReviewDetailsQuery, ReviewDetailDto>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public GetReviewDetailsQueryHandler(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<ReviewDetailDto> Handle(GetReviewDetailsQuery request, CancellationToken cancellationToken)
        {
            var review = await _reviewRepository.GetByIdAsync(request.Id);

            if (review is null)
                throw new NotFoundException(nameof(Domain.Entity.Review), request.Id);

            var data = _mapper.Map<ReviewDetailDto>(review);

            return data;
        }
    }
}