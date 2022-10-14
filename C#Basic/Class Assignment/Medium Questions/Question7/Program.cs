using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        int sum=0;
        System.Console.WriteLine("Output series");
        for (int i=5;i<=24;i=i+2)
        {
            System.Console.WriteLine(i);
            sum=sum+i;


        }
        System.Console.WriteLine("Sum:"+sum);
    }
}