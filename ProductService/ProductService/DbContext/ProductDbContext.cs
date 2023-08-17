

using Microsoft.EntityFrameworkCore;
using ProductService.Models;

namespace ProductService
{
	public class ProductDbContext : DbContext
    {
     
        public ProductDbContext()
        {
        }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            
        }
        public DbSet<Catalogue> Catalogues { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

