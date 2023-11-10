using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;

namespace OlimPlus.Application.Features.Image.Commands.UpdateImageCommand
{
    public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand, Unit>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public UpdateImageCommandHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
        {
            var imageToUpdate = _mapper.Map<Domain.Entity.Image>(request);
            await _imageRepository.UpdateAsync(imageToUpdate);

            return Unit.Value;
        }
    }
}