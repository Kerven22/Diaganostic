using Diaganostic.Storage.Entities;
using Microsoft.EntityFrameworkCore;

namespace Diaganostic.Storage.DbContexts;

public class DiaganosticDbContext:DbContext
{
    public DiaganosticDbContext(DbContextOptions<DiaganosticDbContext>options):base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}