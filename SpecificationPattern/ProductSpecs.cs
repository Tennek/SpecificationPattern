using SpecificationPattern.Core;
using System;
using System.Linq.Expressions;

namespace SpecificationPattern
{
    public class MinimumPriceSpecification : SpecificationBase<Product>
    {
        private readonly double _minPrice;

        public MinimumPriceSpecification(double minPriceInclusive)
        {
            _minPrice = minPriceInclusive;
        }

        public double MinimumPriceInclusive
        {
            get { return _minPrice; }
        }

        public override Expression<Func<Product, bool>> SpecExpression
        {
            get { return p => p.Price >= _minPrice; }
        }
    }

    public class MaximumPriceSpecification : SpecificationBase<Product>
    {
        private readonly double _maxPrice;

        public MaximumPriceSpecification(double maxPriceInclusive)
        {
            _maxPrice = maxPriceInclusive;
        }

        public double MaximumPriceInclusive
        {
            get { return _maxPrice; }
        }

        public override Expression<Func<Product, bool>> SpecExpression
        {
            get { return p => p.Price <= _maxPrice; }
        }
    }
}
