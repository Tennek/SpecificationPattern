using SpecificationPattern.Core;
using System.Collections.Generic;
using System.Linq;

namespace SpecificationPattern
{
    public class ProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            this._products = new List<Product>
            {
                new Product() {Name = "product1", Price = 5.00},
                new Product() {Name = "product2", Price = 7.00},
                new Product() {Name = "product3", Price = 6.00},
                new Product() {Name = "product4", Price = 15.00},
                new Product() {Name = "product5", Price = 50.00},
                new Product() {Name = "product6", Price = 48.00},
                new Product() {Name = "product7", Price = 500.00},
                new Product() {Name = "product8", Price = 399.00},
                new Product() {Name = "product9", Price = 63.00},
                new Product() {Name = "product10", Price = 14.00},
            };
        }

        public IEnumerable<Product> FindAll(ISpecification<Product> spec)
        {
            return _products.Where(spec.IsSatisfiedBy);
        }
    }
}
