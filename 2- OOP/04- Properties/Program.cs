using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar = new Dollar(1.4m);
            dollar.SetAmount(0.4m); // set
            Console.WriteLine(dollar.Amount); // get
            Console.WriteLine(dollar.IsZero);
            Console.WriteLine(dollar.ConversionFactor);
            Console.ReadKey();
        }
    }

    class Dollar
    {
        private decimal _amount;

        // public decimal Amount { get; set; }
        
        public decimal Amount
        {
            get => this._amount;
            private set => this._amount = ProcessValue(value);
        }

        public bool IsZero => _amount == 0;

        public decimal ConversionFactor { get; } = 1.2m;

        public void SetAmount(decimal value)
        {
            Amount = value;
        }

        public Dollar(decimal amount)
        {
            this._amount = ProcessValue(amount);
        }

        private decimal ProcessValue(decimal value) => (value <= 0) ? 0 : Math.Round(value, 2);
    }
}