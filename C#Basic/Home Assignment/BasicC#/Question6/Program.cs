using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the price: ");
        int price=Convert.ToInt32(Console.ReadLine());
        Double total =price+(price*0.18);
        Console.WriteLine($"Total price: {total}");


    }
}