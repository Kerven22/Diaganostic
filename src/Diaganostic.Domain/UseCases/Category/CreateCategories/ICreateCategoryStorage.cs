using Diaganostic.Domain.UseCases.Models;

namespace Diaganostic.Domain.UseCases.Category.CreateCategories;

public interface ICreateCategoryStorage
{
    public Task<CategoryDto> CreateCategory(string name, IEnumerable<ProductDto> products,
        CancellationToken cancellationToken); 
}