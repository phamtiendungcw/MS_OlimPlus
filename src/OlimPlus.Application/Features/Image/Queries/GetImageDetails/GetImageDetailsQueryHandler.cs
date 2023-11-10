using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.Image;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Image.Queries.GetImageDetails
{
    public class GetImageDetailsQueryHandler : IRequestHandler<GetImageDetailsQuery, ImageDetailDto>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public GetImageDetailsQueryHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<ImageDetailDto> Handle(GetImageDetailsQuery request, CancellationToken cancellationToken)
        {
            var image = await _imageRepository.GetByIdAsync(request.Id);

            if (image == null)
                throw new NotFoundException(nameof(Domain.Entity.Image), request.Id);

            var data = _mapper.Map<ImageDetailDto>(image);

            return data;
        }
    }
}