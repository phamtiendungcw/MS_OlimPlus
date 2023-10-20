using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts;
using OlimPlus.Application.DTO.Category;
using OlimPlus.Application.Exceptions;
using Entity = OlimPlus.Domain.Entity;

namespace OlimPlus.Application.Features.Category.Queries.GetCategoryDetails
{
    public class GetCategoryDetailsQueryHandler : IRequestHandler<GetCategoryDetailsQuery, CategoryDetailDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryDetailsQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDetailDto> Handle(GetCategoryDetailsQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);

            // Verify that record exists
            if (category == null)
                throw new NotFoundException(nameof(Entity.Category), request.Id);

            var data = _mapper.Map<CategoryDetailDto>(category);

            return data;
        }
    }
}