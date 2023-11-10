using MediatR;

namespace OlimPlus.Application.Features.User.Commands.DeleteUserCommand
{
    public class DeleteUserCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}