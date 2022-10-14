using System;
namespace ByNumberofArguments;
class Program 
{
    static void Display(int number)
    {
        System.Console.WriteLine("Arguments: "+number);

    }
    static void Display(int number1,int number2)
    {
        System.Console.WriteLine($"Arguments:{number1} and {number2}");
    }
    public static void Main(string[] args)
    {
        Display(3);
        Display(4,5);
        
    }
    
}