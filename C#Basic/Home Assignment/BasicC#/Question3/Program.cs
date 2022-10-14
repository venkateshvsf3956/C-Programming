using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {

     Console.WriteLine("Enter the amount of celsius:");
     int celsius=Convert.ToInt32(Console.ReadLine());
     double div=(double)9/5;

     double fahernHeit=(double)(celsius*div)+32;
     double kelvin=(double)fahernHeit+217;
     Console.WriteLine($"Fahrenheit:{fahernHeit}, Kelvin :{kelvin}");

    }
}
