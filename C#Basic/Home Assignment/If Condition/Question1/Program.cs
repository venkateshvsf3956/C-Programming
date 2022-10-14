using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number:");
        int i=Convert.ToInt32(Console.ReadLine());
        if (i%2==0)
        {
            Console.WriteLine($"{i} is an even number.");
        }
        else
        {
            Console.WriteLine($"{i} is an odd number");

        }
        
    }
}
