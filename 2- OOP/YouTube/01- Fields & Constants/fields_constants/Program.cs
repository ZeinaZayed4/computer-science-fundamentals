using System;
using System.ComponentModel;

namespace fields_constants
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[2];
            
            Employee e1 = new Employee();
            
            Console.WriteLine("First Employee");
            Console.Write("First name: ");
            e1.FName = Console.ReadLine();
            
            Console.Write("Last name: ");
            e1.LName = Console.ReadLine();
            
            Console.Write("Wage: ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Logged Hours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[0] = e1;
            
            Employee e2 = new Employee();
            
            Console.WriteLine("\nSecond Employee");
            Console.Write("First name: ");
            e2.FName = Console.ReadLine();
            
            Console.Write("Last name: ");
            e2.LName = Console.ReadLine();
            
            Console.Write("Wage: ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Logged Hours: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            emps[1] = e2;

            foreach (var emp in emps)
            {
                var netSalary = emp.Wage * emp.LoggedHours - (emp.Wage * emp.LoggedHours * Employee.TAX); 
                
                Console.WriteLine($"First name: {emp.FName}");
                Console.WriteLine($"Last name: {emp.LName}");
                Console.WriteLine($"Wage: {emp.Wage}");
                Console.WriteLine($"Logged hours: {emp.LoggedHours}");
                Console.WriteLine($"Net salary: {netSalary}");
                
                Console.WriteLine("\n------------------------");
            }

            Console.Read();
        }
    }
}
