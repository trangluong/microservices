using System;
using ProductService.Models;

namespace ProductService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;
        public ProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.AsEnumerable();
        }
    }
}

