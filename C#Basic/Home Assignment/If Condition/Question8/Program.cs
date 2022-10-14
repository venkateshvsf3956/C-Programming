using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Your Sugar level:");
        int sugar=Convert.ToInt32(Console.ReadLine());
        if (sugar<90)
        {
            System.Console.WriteLine("Low sugar");
        }
        else if ((90>=sugar) && (130<sugar))
        {
            System.Console.WriteLine("Normal");
        }
        else if ((130>=sugar) && (140<sugar))
        {
            System.Console.WriteLine("Medium");
        }
        else if ((140>=sugar)&& (170<sugar))
        {
            System.Console.WriteLine("try to reduce it from now");
        }
        else
        {
            System.Console.WriteLine("You are a very high Sugar Patient ");
        }
    }
}
