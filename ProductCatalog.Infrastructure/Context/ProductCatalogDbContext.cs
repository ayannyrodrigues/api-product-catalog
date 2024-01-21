using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.Models;

namespace ProductCatalog.Infrastructure.Context
{
    public class ProductCatalogDbContext : DbContext
    {
        public ProductCatalogDbContext(DbContextOptions<ProductCatalogDbContext> options) : base (options) {}

        public DbSet<Category>? Categories { get; set; }

        public DbSet<Product>? Products { get; set; }
    }
}
