using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.SetPrice(6000); // c1.Price = 6000;
            
            Car c2 = new Car();
            c2.SetPrice(4000);

            Console.WriteLine(c1.GetPrice());
            c1.Display();
            c2.Display();
            
            Console.ReadKey();
        }
    }
}
