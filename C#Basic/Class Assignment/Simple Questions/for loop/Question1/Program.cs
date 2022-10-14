using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the value of x:");
        int x=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the value of y");
        int y=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for (int i =1;i<=y;i++)
        {
            sum=sum+(x*x);

        }
        System.Console.WriteLine(sum);
    }
}