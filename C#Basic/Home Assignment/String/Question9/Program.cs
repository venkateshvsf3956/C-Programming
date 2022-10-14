using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string:");
        string str=Console.ReadLine();
        System.Console.WriteLine("Input substring to search:");
        string str2=Console.ReadLine();
        bool m= str.Contains(str2);
        if (m)
        {
            System.Console.WriteLine("The substring exists in the string");
        }
        else{
            System.Console.WriteLine("The substring is not in string.");
        }
    }
}