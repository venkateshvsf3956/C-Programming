using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter meter:");
        int meter=Convert.ToInt32(Console.ReadLine());
        int cm=meter*100;
        int mm=cm*10;
        double inch=39.3*meter;
        int foot=12*meter;
        double mile=0.0006213715277778*meter;
        Console.WriteLine($"CM={cm}");
        Console.WriteLine($"MM={mm}");
        Console.WriteLine($"Inch={inch}");
        Console.WriteLine($"Foot={foot}");
        Console.WriteLine($"Mile={mile}");


    }
}
