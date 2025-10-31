namespace Diaganostic.Domain.UseCases.Models;

public class CategoryDto
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }
    public IEnumerable<ProductDto>? Products { get; set; }
}