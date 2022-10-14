using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        for (int i=1;i<=20;i++)
        {
            for (int j=1;j<=20;j++)
            {
                System.Console.WriteLine($" {i}*{j}={i*j}");
            }
        }
    }
}