using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.Exceptions;

namespace OlimPlus.Application.Features.Category.Commands.CreateCategoryCommand
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateCategoryCommandValidator(_categoryRepository);
            var validatorResult = await validator.ValidateAsync(request);

            if (validatorResult.Errors.Any())
                throw new BadRequestException("Invalid category", validatorResult);

            var categoryToCreate = _mapper.Map<Domain.Entity.Category>(request);
            await _categoryRepository.CreateAsync(categoryToCreate);

            return categoryToCreate.Id;
        }
    }
}