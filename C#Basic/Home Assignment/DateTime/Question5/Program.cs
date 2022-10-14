using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime decemberEnd=new DateTime(2000,12,31);
        for (int i=0;i<=20;i++)
        {
            DateTime display=decemberEnd.AddYears(i);
            System.Console.WriteLine($"{display}: day {display.DayOfYear} of {display.Year} ({DateTime.IsLeapYear(display.Year)}Leap year)");
        }
    }
}