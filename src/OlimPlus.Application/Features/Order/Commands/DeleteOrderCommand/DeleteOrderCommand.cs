using MediatR;

namespace OlimPlus.Application.Features.Order.Commands.DeleteOrderCommand
{
    public class DeleteOrderCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}