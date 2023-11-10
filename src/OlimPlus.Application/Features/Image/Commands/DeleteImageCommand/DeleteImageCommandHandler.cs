using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Image.Commands.DeleteImageCommand
{
    public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand, Unit>
    {
        private readonly IImageRepository _imageRepository;

        public DeleteImageCommandHandler(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task<Unit> Handle(DeleteImageCommand request, CancellationToken cancellationToken)
        {
            var imageToDelete = await _imageRepository.GetByIdAsync(request.Id);
            if (imageToDelete is null)
                throw new NotFoundException(nameof(Domain.Entity.Image), request.Id);
            await _imageRepository.DeleteAsync(imageToDelete);

            return Unit.Value;
        }
    }
}