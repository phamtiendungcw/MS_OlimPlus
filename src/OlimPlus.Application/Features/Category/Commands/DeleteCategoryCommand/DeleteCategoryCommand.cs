using MediatR;

namespace OlimPlus.Application.Features.Category.Commands.DeleteCategoryCommand
{
    public class DeleteCategoryCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}