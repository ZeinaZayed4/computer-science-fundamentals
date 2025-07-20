namespace OOP
{
    public class Employee
    {
        public static double TAX = 0.03;

        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;

        private double Calculate() => Wage * LoggedHours;
        private double CalculateTax() => Calculate() * TAX;
        private double CalculateNet() => Calculate() - CalculateTax();

        public string PrintSlip()
        {
            return  $"\nFirst name: {FName}" + 
                    $"\nLast name: {LName}" + 
                    $"\nWage: {Wage}" + 
                    $"\nLogged hours: {LoggedHours}" +
                    "\n--------------------------------" +
                    $"\nSalary: {Calculate()}" +
                    $"\nDeductible tax ({Employee.TAX * 100}%) amount: {CalculateTax()}" + 
                    $"\nNet salary: {CalculateNet()}\n";
        }
    }
}
