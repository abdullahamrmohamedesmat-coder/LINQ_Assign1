using LINQ.DataSources;
using System.ComponentModel.DataAnnotations;

namespace LINQ.DataSource
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st
            var results = Source.ProductList.Where(p => p.Category == "Seafood").Select(p =>new { p.ProductName, p.UnitPrice });

            foreach(var result in results)
            {
                Console.WriteLine(result);
            }

        }
    }
}
