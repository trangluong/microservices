using System;
using ProductService.Models;

namespace ProductService.Repositories
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetProducts();
	}
}

