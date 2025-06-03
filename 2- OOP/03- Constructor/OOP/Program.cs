using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date
            Date d1 = new Date(29, 02, 2000);
            Date d2 = new Date(6, 2002);
            Date d3 = new Date(2002);
            
            Console.WriteLine(d1.GetDate());
            Console.WriteLine(d2.GetDate());
            Console.WriteLine(d3.GetDate());

            // Employee
            Employee e1 = new Employee();
            e1.Id = 4;
            e1.FName = "Zeina";
            e1.LName = "Zayed";

            // Object Initializer (mostly used)
            Employee e2 = new Employee
            {
                Id = 8,
                FName = "Zeina",
                LName = "Zayed"
            };

            Employee e3 = new Employee(2)
            {
                FName = "Zeina",
                LName = "Zayed"
            };
            Console.WriteLine(e3.DisplayName());
            
            // Customer
            Customer c1 = Customer.Create(4, "Zeina", "Zayed");
            Console.WriteLine(c1.DisplayCustomerData());
            
            Console.ReadKey();
        }
    }

    public class Date
    {
        private static readonly int[] DaysToMonth365 = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private static readonly int[] DaysToMonth366 = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        private readonly int _day = 01;
        private readonly int _month = 01;
        private readonly int _year = 0001;

        public Date(int day, int month, int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int [] days = isLeap ? DaysToMonth366 : DaysToMonth365;
                if (day >= 1 && day <= days[month])
                {
                    this._day = day;
                    this._month = month;
                    this._year = year;
                }
            }
        }
        
        public Date(int year): this(01, 01, year)
        {
            
        }
        
        public Date(int month, int year): this(01, month, year)
        {
            
        }
        
        public string GetDate()
        {
            return $"{_day.ToString().PadLeft(2, '0')}" +
                   $"/{_month.ToString().PadLeft(2, '0')}" +
                   $"/{_year.ToString().PadLeft(4, '0')}";
        }
    }

    public class Employee
    {
        public Employee()
        {
            
        }
        
        public Employee(int id)
        {
            Id = id;
        }
        
        public int Id;
        public string FName;
        public string LName;

        public string DisplayName()
        {
            return $"Id: {Id}, Name: {FName} {LName}.";
        }
    }

    public class Customer
    {
        private Customer()
        {
            
        }
        
        private Customer(int id, string fName, string lname)
        {
            _id = id;
            _fName = fName;
            _lName = lname;
        }

        public static Customer Create(int id, string fName, string lname)
        {
            return new Customer(id, fName, lname);
        }
        
        private int _id;
        private string _fName;
        private string _lName;
        
        public string DisplayCustomerData()
        {
            return $"Id: {_id}, Name: {_fName} {_lName}.";
        }
    }
}
