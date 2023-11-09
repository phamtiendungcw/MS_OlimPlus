using MediatR;
using OlimPlus.Application.DTO.Image;

namespace OlimPlus.Application.Features.Image.Queries.GetImageDetails
{
    public record class GetImageDetailsQuery(int Id) : IRequest<ImageDetailDto>;
}