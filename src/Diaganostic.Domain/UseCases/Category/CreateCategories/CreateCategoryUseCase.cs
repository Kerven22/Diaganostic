using Diaganostic.Domain.UseCases.Models;
using MediatR;

namespace Diaganostic.Domain.UseCases.Category.CreateCategories;

public class CreateCategoryUseCase:IRequestHandler<CreateCategoryCommand, CategoryDto>
{
    private readonly ICreateCategoryStorage _storage; 
    public CreateCategoryUseCase(ICreateCategoryStorage storage)
    {
        _storage = storage; 
    }
    public async Task<CategoryDto> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var categoryDto = await _storage.CreateCategory(request.name, request.products, cancellationToken);
        return categoryDto; 
    }
}