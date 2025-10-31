namespace Diaganostic.Domain.UseCases.Models;

public class ProductDto
{
    public Guid CategoryId { get; set; }
    public Guid ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
}