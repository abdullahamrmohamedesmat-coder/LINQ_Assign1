using LINQ.DataSources;
using System.ComponentModel.DataAnnotations;
using static LINQ.DataSources.Source; 

    

namespace LINQ.DataSource
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st
            //var results = Source.ProductList.Where(p => p.Category == "Seafood").Select(p =>new { p.ProductName, p.UnitPrice });

            //foreach(var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //2 st 
            //var results = Source.ProductList.Select(p => p.ProductName);

            //3st 
            //var results=ProductList.OrderBy(p=>p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });

            //4st
            //var results = ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);

            //5st
            //var results = ProductList.Where(p => p.Category == "Spices & Condiments" && p.UnitsInStock > 0);


            //6st
            var results = ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"

            });

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine(results.GetType());

        }
    }
}
