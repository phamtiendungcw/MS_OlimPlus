using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Review.Commands.DeleteReviewCommand
{
    public class DeleteReviewCommandHandler : IRequestHandler<DeleteReviewCommand, Unit>
    {
        private readonly IReviewRepository _reviewRepository;

        public DeleteReviewCommandHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Unit> Handle(DeleteReviewCommand request, CancellationToken cancellationToken)
        {
            var reviewToDelete = await _reviewRepository.GetByIdAsync(request.Id);
            if (reviewToDelete is null)
                throw new NotFoundException(nameof(Domain.Entity.Review), request.Id);
            await _reviewRepository.DeleteAsync(reviewToDelete);

            return Unit.Value;
        }
    }
}