using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the First number:");
        int first=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int second=Convert.ToInt32(Console.ReadLine());

        int add=first+second;
        int sub=first-second;
        int mul=first*second;
        int div=first/second;
        int floorDivison=div/second;

        Console.WriteLine($"Addition:{add} ,Substraction:{sub} ,Multiplication:{mul} ,Divison:{div} ,FloorDivison:{floorDivison}");


    
    }
}