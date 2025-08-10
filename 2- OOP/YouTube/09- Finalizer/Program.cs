using System;

namespace Finalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeSomeGarbage();
            Console.WriteLine($"Memory used before collection {GC.GetTotalMemory(false):N0}");
            GC.Collect(); // explicit cleaning
            Console.WriteLine($"Memory used after collection {GC.GetTotalMemory(true):N0}");
            Console.ReadKey();
        }

        static void MakeSomeGarbage()
        {
            Version v;

            for (int i = 0; i < 1000; i++)
            {
                v = new Version();
            }
        }
    }
}