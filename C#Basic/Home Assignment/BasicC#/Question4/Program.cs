using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius:");
        int radius=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Height: ");
        int height =Convert.ToInt32(Console.ReadLine());

        int r=radius*radius;
        double volume=(double)3.14*4*height;
        Console.WriteLine($"Volume:{volume}");


    }
}