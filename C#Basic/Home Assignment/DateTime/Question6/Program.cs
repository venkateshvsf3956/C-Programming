using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime today=DateTime.Now;
        DateTime output=today.AddDays(40);
        System.Console.WriteLine("today"+today);
        System.Console.WriteLine("40 days from today:{0:dddd}",output);
    }
}