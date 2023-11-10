using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;

namespace OlimPlus.Application.Features.Review.Commands.UpdateReviewCommand
{
    public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand, Unit>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public UpdateReviewCommandHandler(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var reviewToUpdate = _mapper.Map<Domain.Entity.Review>(request);
            await _reviewRepository.UpdateAsync(reviewToUpdate);

            return Unit.Value;
        }
    }
}