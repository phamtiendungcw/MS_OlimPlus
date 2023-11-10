using MediatR;

namespace OlimPlus.Application.Features.Product.Commands.DeleteProductAttributeCommand
{
    public class DeleteProductAttributeCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}