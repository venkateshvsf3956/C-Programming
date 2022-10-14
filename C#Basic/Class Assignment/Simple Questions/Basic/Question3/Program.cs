using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the celsius:");
        double input=Convert.ToDouble(Console.ReadLine());
        decimal f=(decimal)input*(9/5)+32;
        System.Console.WriteLine("Fahrenheit: "+f);

    }
}
