using FluentValidation;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Category.Commands.CreateCategoryCommand
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateCategoryCommandValidator(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            RuleFor(x => x.CategoryName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must be fewer than 50 characters.");
            RuleFor(x => x)
                .MustAsync(CategoryNameUnique)
                .WithMessage("Category already exists.");
        }

        private Task<bool> CategoryNameUnique(CreateCategoryCommand command, CancellationToken token)
        {
            return _categoryRepository.IsCategoryUnique(command.CategoryName);
        }
    }
}