namespace ConsoleNorthwind
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindDbContext db = new NorthwindDbContext())
            {
                DbSet<Category> data = db.Categories;
                foreach (Category item in data)
                {
                    Console.WriteLine(item.CategoryId + " " + item.CategoryName);
                }
                Console.WriteLine();

                List<CustOrderHistReturnModel> history = db.CustOrderHist("ALFKI");
                foreach (CustOrderHistReturnModel item in history)
                {
                    Console.WriteLine("{0, 2} {1}", item.Total, item.ProductName);
                }

                Console.WriteLine();

                OrderDetail orderDetail = db.OrderDetails.First();
                Console.WriteLine(orderDetail.Product.ProductName);
            }
        }
    }
}
