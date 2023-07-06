using Microsoft.EntityFrameworkCore;
using WebApplication6.Model;

namespace WebApplication6.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext>options) :base(options)
        { }
        public DbSet<ProductList> Products { get; set; }
    }
}
