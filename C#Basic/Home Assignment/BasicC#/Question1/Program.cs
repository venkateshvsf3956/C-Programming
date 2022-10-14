using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter hello:");
        string hello=Console.ReadLine();

        Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();

        //concatination
        Console.WriteLine(hello+":"+name);
        //Place holder
        Console.WriteLine("{0}:{1}",hello,name);
        //Interpolation
        Console.WriteLine($"{hello}: {name}");

    }
}