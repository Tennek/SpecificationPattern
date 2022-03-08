using SpecificationPattern.Core.Operators;
using System;
using System.Linq;

namespace SpecificationPattern
{
    class Program
    {
        //https://davefancher.com/2012/07/03/specifications-expression-trees-and-nhibernate/

        static void Main(string[] args)
        {
            var repo = new ProductRepository();

            var spec = 
                new MinimumPriceSpecification(50).And(
                    new MaximumPriceSpecification(100)
                );

            var result = repo.FindAll(spec);

            foreach (var item in result.OrderBy(x => x.Name))
                Console.WriteLine($"{item.Name} : {item.Price}");

            Console.ReadLine();
        }
    }
}
