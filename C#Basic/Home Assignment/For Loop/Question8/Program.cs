using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        int count=4;
        int integer=1;
        for (int i=1;i<=count;i++)
        {
            for (int j=count-i;j>=1;j--)
            {
                System.Console.Write(" ");
            }
            for (int k=1;k<=i;k++)
            {
                System.Console.Write(integer++);

            }
            System.Console.WriteLine();
        }
    }
}
