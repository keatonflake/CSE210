using System;

class Program
{
    static void Main(string[] args)
    {
        var hourly = new HourlyEmployee(1000, "elon musk", 14);
        var salary = new SalaryEmployee(90000, "rob opp", 14);

        var employees = new List<Employee>{hourly, salary};
        foreach (var employee in employees) {
            Console.WriteLine(employee._name);
            Console.WriteLine(employee.PayPeriodWages());
        }
    }
}
class Employee
{
    public Employee(string name, int payPeriodLength){
        _name = name;
        _payPeriodLength = payPeriodLength;
    }
    public string _name;

    protected int _payPeriodLength;

    public virtual double PayPeriodWages() {
        return 0;
    }
}
class HourlyEmployee :Employee
{      
    public HourlyEmployee(double rate, string name, int payPeriodLength) 
    : base(name, payPeriodLength)
    {
        _rate = rate;
    }
    double _rate;

    public override double PayPeriodWages()
    {
        return _rate * 8 * _payPeriodLength;
    }
}

class SalaryEmployee : Employee
{
    public SalaryEmployee(double annualRate, string name, int payPeriodLength) : base(name, payPeriodLength){
        _annualRate = annualRate;
    }
    double _annualRate;

    public override double PayPeriodWages()
    {
        return _payPeriodLength / 365 * _annualRate;
    }

}