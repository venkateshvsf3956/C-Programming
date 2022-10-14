using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        for (int i=1;i<=5;i++)
        {
            for (int j=1;j<=5-i;j++)
            {
                System.Console.Write(" ");
            }
            for (int k=1;k<i*2;k++)
            {
                System.Console.Write("*");
            }
        System.Console.WriteLine();
        }
    }
}
