using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        int input =10000;
        int da=input+1000;
        int hra=da+1000;
        int annual=hra*12;
        int taxes=annual-(5*1440);

        System.Console.WriteLine("Annual income-"+taxes);
    }
}