using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Diaganostic.Storage.Entities;

public class Product
{
    [Key]
    public Guid ProductId { get; set; }
    public Guid CategoriId { get; set; }
    
    [ForeignKey(nameof(CategoriId))]
    public Category Category { get; set; }
    
    public string Name { get; set; }
    
    [Precision(18,2)] 
    public Decimal Price { get; set; }
}