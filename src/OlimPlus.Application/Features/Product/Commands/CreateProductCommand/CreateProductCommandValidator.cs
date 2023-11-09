using FluentValidation;
using OlimPlus.Application.Contracts;

namespace OlimPlus.Application.Features.Product.Commands.CreateProductCommand
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator(IProductRepository productRepository)
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MinimumLength(20).WithMessage("{PropertyName} must be more than 20 characters.")
                .MaximumLength(500).WithMessage("{PropertyName} must be fewer than 500 characters.");
            RuleFor(x => x.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0).WithMessage("{PropertyName} is greater than 0.")
                .LessThan(10000000000).WithMessage("{PropertyName} is less than 10000000000.");
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MinimumLength(3).WithMessage("{PropertyName} must be more than 3 characters.")
                .MaximumLength(25).WithMessage("{PropertyName} must be fewer than 25 characters.");
            RuleFor(x => x.StockQuantity)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0).WithMessage("{PropertyName} is greater than 0.")
                .LessThan(10000).WithMessage("{PropertyName} is less than 10000.");
        }
    }
}