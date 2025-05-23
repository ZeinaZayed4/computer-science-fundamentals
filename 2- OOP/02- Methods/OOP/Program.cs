using System;
using System.ComponentModel;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[2];
            
            Employee e1 = new Employee();
            
            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine());
            
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
                Console.WriteLine(emp.PrintSlip());
            }

            Demo d = new Demo();
            // caller
            d.DoSomething();
            
            var z = d.DoSomethingReturn(); // primary expression
            Console.WriteLine(z);

            var age = 22;
            d.DoSomethingParam(ref age); // age => argument passed
            Console.WriteLine(age); // 25
            
            d.Promote(100, "Spain", "Mandarin Oriental Ritz 3days/2nights");

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Demo.PrintEvens(numbers);
            
            Console.ReadKey();
        }
    }

    public class Demo
    {
        // Method, Callee
        public void DoSomething()
        {
            Console.WriteLine("Do something...");
        }

        public int DoSomethingReturn()
        {
            return 4;
        }

        // age => parameter
        public void DoSomethingParam(ref int age)
        {
            age += 3;
        }
        
        // Method overloading
        public void Promote(double amount)
        {
            Console.WriteLine($"You've got a promotion of ${amount}");
        }
        
        public void Promote(double amount, string trip)
        {
            Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip}");
        }
        
        public void Promote(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You've got a promotion of ${amount} and a trip {trip} with {hotel}");
        }
        
        // Local method
        public static void PrintEvens(int[] original)
        {
            foreach (var n in original)
            {
                if (IsEven(n))
                {
                    Console.Write(n + " ");
                }
            }
            
            // Local method & expression bodies method
            bool IsEven(int number) => number % 2 == 0;
        }
    }
}
