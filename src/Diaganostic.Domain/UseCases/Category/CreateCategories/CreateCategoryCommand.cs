using Diaganostic.Domain.UseCases.Models;
using MediatR;

namespace Diaganostic.Domain.UseCases.Category.CreateCategories;

public record CreateCategoryCommand(string name, IEnumerable<ProductDto>? products):IRequest<CategoryDto>;