using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Physics mark: ");
        int physics=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Chemistry mark: ");
        int chemistry=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Mathematics: ");
        int maths=Convert.ToInt32(Console.ReadLine());
        
        int sum =physics+chemistry+maths;
        Console.WriteLine($"Sum:{sum}");
        double average=(double)sum/300;
        double percent=average*100;
        Console.WriteLine($"Percentage:{percent}");
        
        
    }
}