using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the table should be calculated:");
        int input=int.Parse(Console.ReadLine());
        for(int i=input;i<=input;i++)
        {
            for (int j=1;j<=10;j++)
            {
                System.Console.WriteLine($"{i}x{j}={i*j}");
            }
        
        }
        
        
    }
}