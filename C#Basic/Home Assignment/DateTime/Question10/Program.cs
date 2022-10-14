using System;
namespace Question10;
class Program 
{
    public static void Main(string[] args)
    {
        
        DateTime today=DateTime.Now;
        DateTime tommorow =today.AddDays(1);
        DateTime yesterday=today.AddDays(-1);
        System.Console.WriteLine("Tommorow:"+tommorow.ToString("dd/MM/yyyy"));
        System.Console.WriteLine("yesterday:"+yesterday.ToString("dd/MM/yyyy"));
    }
}