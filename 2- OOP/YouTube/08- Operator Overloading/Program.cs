using System;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10m);
            Money m2 = new Money(20m);

            Money m3 = m1 + m2;
            
            Console.WriteLine($"Money m1: ${m1.Amount}, Money m2: ${m2.Amount}");
            Console.WriteLine($"Money m3: ${m3.Amount}");

            Money m4 = m2 - m1;
            Console.WriteLine($"Money m4: ${m4.Amount}");

            Console.WriteLine(m4 < m3);
            
            Console.ReadKey();
        }
    }

    class Money
    {
        private decimal _amount;
        public decimal Amount => _amount;

        public Money(decimal amount)
        {
            _amount = Math.Round(amount, 2);
        }
        
        public static Money operator +(Money money1, Money money2)
        {
            var value = money1.Amount + money2.Amount;
            
            return new Money(value);
        }

        public static Money operator -(Money money1, Money money2)
        {
            var value = money1.Amount - money2.Amount;
            
            return new Money(value);
        }
        
        public static bool operator >(Money money1, Money money2)
        {
            return money1.Amount > money2.Amount;
        }
        
        public static bool operator <(Money money1, Money money2)
        {
            return money1.Amount < money2.Amount;
        }
    }
}