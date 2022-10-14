using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        for (int i=1994;i<=2014;i++)
        {
            if (DateTime.IsLeapYear(i))
            {
                System.Console.WriteLine($"{i} is a Leap year");
                DateTime leap=new DateTime(i,2,29);
                DateTime nextYear=leap.AddYears(1);
                System.Console.WriteLine($"One year from {leap.ToString()} is {nextYear.ToString()}");
            }
        }
    }
}