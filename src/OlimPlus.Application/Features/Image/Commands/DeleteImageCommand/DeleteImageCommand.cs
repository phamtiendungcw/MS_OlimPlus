using MediatR;

namespace OlimPlus.Application.Features.Image.Commands.DeleteImageCommand
{
    public class DeleteImageCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}