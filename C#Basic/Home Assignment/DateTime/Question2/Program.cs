using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in the correct format dd/MM/yyyy hh:mm:ss tt");
        DateTime d=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        System.Console.WriteLine($"Complete date:{d.ToString("dd/MM/yyyy HH:mm:ss")}");
        Console.WriteLine($"Short date:{d.ToShortDateString()}");
        Console.WriteLine($"Long Date: {d.ToLongDateString()}");
        System.Console.WriteLine($"12 hour format:{d.ToString("dd/MM/yyyy hh:mm:ss tt")}");
        Console.WriteLine($"Date only: {d.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Time only: {d.ToString("hh:mm:ss tt")}");
    }
}