using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Today;
        DateTime nextYear=today.AddYears(1);
        DateTime oldYear=today.AddYears(-1);
        System.Console.WriteLine($"{today} is later than {oldYear}");
        System.Console.WriteLine($"{today} is earlier than {nextYear}");
    }
}
