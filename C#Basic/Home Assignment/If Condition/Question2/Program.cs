using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your age: ");
        int i=Convert.ToInt32(Console.ReadLine());
        if (i>=18)
        {
            System.Console.WriteLine("Congratulation! You are eligible to vote.");
        }
        else
        {
            System.Console.WriteLine("You are not eligibe to vote.");
        }
    }
}