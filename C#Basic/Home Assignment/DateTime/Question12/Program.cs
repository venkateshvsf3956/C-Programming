using System;
using System.Globalization;
namespace Question12;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the month:");
        int month=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the year:");
        int year=Convert.ToInt32(Console.ReadLine());
        DateTimeFormatInfo info=new DateTimeFormatInfo();
        String monthNumber=info.GetMonthName(month);
        int days=DateTime.DaysInMonth(year,month);
        System.Console.WriteLine("number of days:"+days);
        
    }
}