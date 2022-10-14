using System;
namespace Question13;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the day:");
        int day=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Month:");
        int month=Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the year: ");
        int year=Convert.ToInt32(Console.ReadLine());
        DateTime date=new DateTime(year,month,day);
        System.Console.WriteLine("The format:"+date);
        
    }
}