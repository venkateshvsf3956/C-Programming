using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the india Rupees:");
        int input=Convert.ToInt32(Console.ReadLine());
        decimal usd =(decimal)122/input;
        decimal eur=(decimal)126/input;
        decimal cny=(decimal)879/input;
        System.Console.WriteLine("USD:"+usd);
        System.Console.WriteLine("EUR:"+eur);
        System.Console.WriteLine("CNY:"+cny);
    }
}