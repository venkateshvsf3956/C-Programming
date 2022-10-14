using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number:");
        int input=int.Parse(Console.ReadLine());
        System.Console.WriteLine(Prime());
        int  Prime()
        {
        int sum=1;
        
        for (int i=1;i<=input;i++)
        {
            sum=sum*i;
        }
        return sum;
        }

    }
}
