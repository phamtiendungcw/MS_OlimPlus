using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Image;

namespace OlimPlus.Application.Features.Image.Queries.GetAllImages
{
    public class GetAllImagesQueryHandler : IRequestHandler<GetAllImagesQuery, List<ImageDto>>
    {
        private readonly IImageRepository _imageRepository;
        private readonly IMapper _mapper;

        public GetAllImagesQueryHandler(IImageRepository imageRepository, IMapper mapper)
        {
            _imageRepository = imageRepository;
            _mapper = mapper;
        }

        public async Task<List<ImageDto>> Handle(GetAllImagesQuery request, CancellationToken cancellationToken)
        {
            var images = await _imageRepository.GetAllAsync();
            var data = _mapper.Map<List<ImageDto>>(images);

            return data;
        }
    }
}