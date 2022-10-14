using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first string:");
        string str1=Console.ReadLine();
        System.Console.WriteLine("Enter The second string:");
        string str2=Console.ReadLine();
        if (str1==str2)
        {
            System.Console.WriteLine("both are equal");
        }
    }
}