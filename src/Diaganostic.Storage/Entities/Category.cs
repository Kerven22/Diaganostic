using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diaganostic.Storage.Entities;

public class Category
{
    [Key]
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }

    [InverseProperty(nameof(Product.Category))]
    public IEnumerable<Product> Products { get; set; } = null!;
}