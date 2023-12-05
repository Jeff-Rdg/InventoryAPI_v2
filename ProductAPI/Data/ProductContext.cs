using Microsoft.EntityFrameworkCore;
using ProductAPI.Entities;

namespace ProductAPI.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            
        }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Category> Categories { get; set; }
    }
}