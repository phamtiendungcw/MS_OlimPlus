using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;

namespace OlimPlus.Application.Features.Review.Commands.CreateReviewCommand
{
    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand, int>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public CreateReviewCommandHandler(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            var reviewToCreate = _mapper.Map<Domain.Entity.Review>(request);
            await _reviewRepository.CreateAsync(reviewToCreate);

            return reviewToCreate.Id;
        }
    }
}