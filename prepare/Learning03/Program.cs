using System;

class Program
{
    static void Main(string[] args)
    {
        var fraction = new Fraction();
        fraction.SetTop(3);
        fraction.SetBottom(4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine();
        Console.WriteLine(fraction.GetDecimalValue());

}
}
