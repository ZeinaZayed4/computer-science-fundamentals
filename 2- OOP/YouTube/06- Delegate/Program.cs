using System;

namespace Delegate
{
    public delegate void RectDelegate(decimal width, decimal height);
    
    class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee { Id = 1, Name = "Sherouk", Gender = "F", TotalSales = 45000m },
                new Employee { Id = 2, Name = "Kholoud", Gender = "F", TotalSales = 50000m },
                new Employee { Id = 3, Name = "Ohoud", Gender = "F", TotalSales = 60000m },
                new Employee { Id = 4, Name = "Zeina", Gender = "F", TotalSales = 65000m },
                new Employee { Id = 5, Name = "Hana", Gender = "F", TotalSales = 20000m },
                new Employee { Id = 6, Name = "Safa", Gender = "F", TotalSales = 25000m },
                new Employee { Id = 7, Name = "Adam", Gender = "M", TotalSales = 20000m },
                new Employee { Id = 8, Name = "Yahya", Gender = "M", TotalSales = 30000m }
            };

            var report = new Report();
            report.ProcessEmployees(emps, "Employees With Sales $60,000+",
                employee =>  employee.TotalSales > 60000m);
            report.ProcessEmployees(emps, "Employees With Sales Between $30,000 and $60,000",
                employee => employee.TotalSales >= 30000m && employee.TotalSales < 60000m);
            report.ProcessEmployees(emps, "Employees With Sales < $30,000", employee => employee.TotalSales < 30000m);

            var helper = new RectangleHelper();
            RectDelegate rect;
            rect = helper.GetArea;
            rect += helper.GetPerimeter;
            rect(10, 10);

            rect -= helper.GetArea;
            Console.WriteLine("After unsubscribing rect.GetArea");
            rect(10, 10);
            
            Console.ReadKey();
        }
    }

    public class RectangleHelper
    {
        public void GetArea(decimal width, decimal height)
        {
            var result = width * height;
            Console.WriteLine($"Area: {width} x {height} = {result}");
        }
        
        public void GetPerimeter(decimal width, decimal height)
        {
            var result = 2 * (width + height);
            Console.WriteLine($"Perimeter: 2 x ({width} + {height}) = {result}");
        }
    }
}