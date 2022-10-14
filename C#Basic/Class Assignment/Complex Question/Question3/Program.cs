using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string1");
        string str1=Console.ReadLine();
        System.Console.WriteLine("Enter the string2:");
        string str2=Console.ReadLine();
        if (str1.Length==str2.Length)
        {
            System.Console.WriteLine("Its is a Anagram");
        }
        
    }
}