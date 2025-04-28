using Microsoft.EntityFrameworkCore;
using ProductsApi.entities;

namespace ProductsApi
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
