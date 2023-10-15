using MediatR;

namespace OlimPlus.Application.Features.Product.Commands.DeleteProductCommand
{
    public class DeleteProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
