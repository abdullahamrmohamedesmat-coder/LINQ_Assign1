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
            //var results = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"

            //});

            //7st
            //var results = ProductList.Select((Product, Index) => $"{Index + 1}. {Product.ProductName}");

            //8st
            //var results = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //var results = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock).Select(p => new { 
            //    p.ProductName,
            //    p.UnitsInStock 
            //});

            //10st
            //var results = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new
            //             {
            //                 CustomerID = c.CustomerID,
            //                 OrderDate = o.OrderDate
            //             };


            //11st
            var results= ProductList.Select((Product,Index) => new {
                postion= Index+1,
                Product.ProductName,
            });

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            

        }
    }
}
