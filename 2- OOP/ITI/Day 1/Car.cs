using System;

namespace Day1
{
    public class Car
    {
        private double Price;
        private string Number = "1234";

        public void SetPrice(double price)
        {
            if (price >= 5000)
                Price = price;
            else
                Price = 5000;
        }

        public double GetPrice()
        {
            return Price;
        }
        
        public void MoveForward()
        {
            Price = 4000000;
            Number = "1234";
        }

        void Stop()
        {
            
        }

        public void Display()
        {
            Console.WriteLine($"Number: {Number} \t Price: {Price}");
        }
    }
}
