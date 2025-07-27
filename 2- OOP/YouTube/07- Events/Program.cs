using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 100;
            stock.OnPriceChanged += Stock_OnPriceChanged;

            stock.changeStockPriceBy(0.05m);
            stock.changeStockPriceBy(-0.02m);
            stock.changeStockPriceBy(0.00m);
            
            Console.ReadKey();
        }

        private static void Stock_OnPriceChanged(Stock stock, decimal oldPrice)
        {
            string result = "";
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                result = "up";
            }
            else if (oldPrice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                result = "down";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine($"{stock.Name} price is: {stock.Price} - {result}");
        }
    }

    public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);
    
    public class Stock
    {
        private string _name;
        private decimal _price;

        public event StockPriceChangeHandler OnPriceChanged;
        
        public string Name => this._name;

        public decimal Price
        {
            get => this._price;
            set => this._price = value;
        }

        public Stock(string stockName)
        {
            this._name = stockName;
        }

        public void changeStockPriceBy(decimal percent)
        {
            decimal oldPrice = this._price;
            this._price += Math.Round(this._price * percent, 2);
            if (OnPriceChanged != null)
            {
                OnPriceChanged(this, oldPrice);
            }
        }
    }
}