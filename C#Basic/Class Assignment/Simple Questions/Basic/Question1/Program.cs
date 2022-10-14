using System;
namespace Question1;
class Program {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the inches:");
        string input=Console.ReadLine();
        int input1=Convert.ToInt32(input);
        
        double cm=(double)input1*2.54;
        System.Console.WriteLine("Centimeter:"+cm);
    }
}