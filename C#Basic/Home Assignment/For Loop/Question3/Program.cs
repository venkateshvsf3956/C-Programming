using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        int input=Convert.ToInt32(Console.ReadLine());
        
        int i;
        int cube;
        for (i=1;i<=input;i++)
        {
            cube=i*i*i;
            System.Console.WriteLine($"{i} and is cube of {1} is {cube}");

        }
    }
}
