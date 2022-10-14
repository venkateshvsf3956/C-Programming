using System;
namespace Bytype;
class Program 
{
    static void Display(int number)
    {
        System.Console.WriteLine("Arguments integer type:"+number);
    }
    static void Display(string name)
    {
        System.Console.WriteLine("Aruguments string type:"+ name);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\n-----Methods by type of aruguments-----\n");
        Display(2);
        Display("venkat");
        
        
    }
}