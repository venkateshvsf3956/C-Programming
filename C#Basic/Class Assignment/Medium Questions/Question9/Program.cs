using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        for (int i=1;i<=4;i++)
        {
            for (int j=1;j<=4-i;j++)
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