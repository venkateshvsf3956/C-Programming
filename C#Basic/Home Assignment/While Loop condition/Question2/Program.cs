using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number:");
        int input=int.Parse(Console.ReadLine());
        int sum=0;
        int i=1;
        while ( i<=input)
        {
            
            sum+=i*i;
            System.Console.WriteLine($"numbers are:{i}");
            i++;


        }
        System.Console.WriteLine($"Sum of number: {sum}");
    }
}