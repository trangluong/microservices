using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductService.Models
{
	public class Product
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Image { get; set; }
		public Catalogue Catalogue { get; set; }
	}
}

