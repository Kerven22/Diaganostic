using Diaganostic.API.Controllers;

namespace Diaganostic.API.Models;

public class CategoryRequest
{
    public string Name { get; set; }
    public IEnumerable<ProductRequest>? Products { get; set; }
}