using System;
using System.Collections.Generic;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        
        
        DateTime[] dates = { DateTime.Now,new DateTime(2016, 8, 16, 9, 28, 0),new DateTime(2011, 5, 28, 10, 35, 0),new DateTime(1979, 12, 25, 14, 30, 0) };
        
        Console.WriteLine(dates[0].ToString("MM/dd/yyyy HH:mm:ss"));
        Console.WriteLine(dates[0].ToString("MM/dd/yyyy hh:mm:ss tt"));

        Console.WriteLine(dates[1].ToString("MM/dd/yyyy HH:mm:ss"));
        Console.WriteLine(dates[1].ToString("MM/dd/yyyy hh:mm:ss tt"));

        Console.WriteLine(dates[2].ToString("MM/dd/yyyy HH:mm:ss"));
        Console.WriteLine(dates[2].ToString("MM/dd/yyyy hh:mm:ss tt"));

        Console.WriteLine(dates[3].ToString("MM/dd/yyyy HH:mm:ss"));
        Console.WriteLine(dates[3].ToString("MM/dd/yyyy hh:mm:ss tt"));



    }
}