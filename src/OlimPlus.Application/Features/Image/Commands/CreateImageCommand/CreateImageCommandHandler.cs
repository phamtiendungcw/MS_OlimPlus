using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Image.Commands.CreateImageCommand
{
    public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand, int>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public CreateImageCommandHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateImageCommand request, CancellationToken cancellationToken)
        {
            var imageToCreate = _mapper.Map<Domain.Entity.Image>(request);
            await _imageRepository.CreateAsync(imageToCreate);

            return imageToCreate.Id;
        }
    }
}