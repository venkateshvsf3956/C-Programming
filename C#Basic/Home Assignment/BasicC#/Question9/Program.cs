using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        
        //Speed in km/hr *seconds * 5/18
        Console.WriteLine("Enter the Speed in km/hr: ");
        int speed=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the seconds:");
        int sec=Convert.ToInt32(Console.ReadLine());
        double d=(double)5/18;
        
        int distance =Convert.ToInt32(speed*sec*d);
        
        Console.WriteLine($"Distance Travelled:{distance}");

    }
}