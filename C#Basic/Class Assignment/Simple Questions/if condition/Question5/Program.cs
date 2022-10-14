using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a vowel Character:");
        string str=Console.ReadLine();
        if ((str=="a")||(str=="e")||(str=="i")||(str=="o")||(str=="u"))
        {
            System.Console.WriteLine("Its is a vowel");
        }
        else{
            System.Console.WriteLine("Its not a vowel");
        }
    }
}