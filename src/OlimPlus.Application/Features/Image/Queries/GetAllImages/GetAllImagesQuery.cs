using MediatR;
using OlimPlus.Application.DTO.Image;

namespace OlimPlus.Application.Features.Image.Queries.GetAllImages
{
    public record class GetAllImagesQuery : IRequest<List<ImageDto>>;
}