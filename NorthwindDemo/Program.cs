using System;
using System.Linq;

namespace NorthwindDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TileboardLocatorContext())
            {
                /*var data = db.Categories;
                foreach (var item in data)
                {
                    Console.WriteLine(item.CategoryId + " " + item.CategoryName);
                }
                Console.WriteLine();

                var history = db.CustOrderHist("ALFKI");
                foreach (var item in history)
                {
                    Console.WriteLine("{0, 2} {1}", item.Total, item.ProductName);
                }

                Console.WriteLine();

                var orderDetail = db.OrderDetails.First();
                Console.WriteLine(orderDetail.Product.ProductName);*/
            }
        }
    }
}
