using LINQ.DataSources;
using System.ComponentModel.DataAnnotations;
using static LINQ.DataSources.Source; 

    

namespace LINQ.DataSource
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //3st 
            var results=ProductList.OrderBy(p=>p.UnitPrice).Select(p => new { p.ProductName, p.UnitPrice });

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }


        }
    }
}
