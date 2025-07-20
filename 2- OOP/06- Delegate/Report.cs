using System;

namespace Delegate
{
    public class Report
    {
        public delegate bool IllegibleSales(Employee employee);
        
        public void ProcessEmployees(Employee[] employees, string title, IllegibleSales isIllegible)
        {
            Console.WriteLine(title);
            Console.WriteLine("--------------------------------------");

            foreach (var employee in employees)
            {
                if (isIllegible(employee))
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | {employee.TotalSales}");
                }
            }

            Console.WriteLine("\n");
        }
    }
}
