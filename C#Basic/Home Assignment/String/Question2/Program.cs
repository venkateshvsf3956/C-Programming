using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();
        int length=0;
        while (length<=str.Length-1)
        {
            System.Console.WriteLine(str[length]);
            length++;
        }
    }
}