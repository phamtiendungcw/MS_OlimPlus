using MediatR;

namespace OlimPlus.Application.Features.Category.Commands.UpdateCategoryCommand
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public string CategoryName { get; set; } = String.Empty;
    }
}