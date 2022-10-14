using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius");
        double input=Convert.ToDouble(Console.ReadLine());
        double area=(double)3.14*input*input;
        double peri=(double)2*3.14*input;
        System.Console.WriteLine("Area: "+area);
        System.Console.WriteLine("Perimetr: "+peri);
    }
}
