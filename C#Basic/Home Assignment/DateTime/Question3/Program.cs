using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the correct format of date and time dd/MM/yyyy hh:mm:ss tt");
        DateTime d=DateTime.ParseExact(Console.ReadLine(),("dd/MM/yyyy hh:mm:ss tt"),null);
        Console.WriteLine("Date: "+d.Day);       
        Console.WriteLine("Month: "+d.Month);      
        Console.WriteLine("year: "+d.Year);
        Console.WriteLine("Hour: "+d.Hour);         
        Console.WriteLine("Minute: "+d.Minute);      
        Console.WriteLine("Second: "+d.Second);
        Console.WriteLine("Millisecond: "+d.Millisecond);

    }
}