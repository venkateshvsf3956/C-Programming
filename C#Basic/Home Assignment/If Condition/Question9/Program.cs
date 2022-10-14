using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Month:");
        string month=Console.ReadLine();
        if ((month=="December")||(month=="January")|| (month=="February"))
        {
            System.Console.WriteLine("Winter");
        }
        else if ((month=="March")||(month=="April")|| (month=="May"))
        {
            System.Console.WriteLine("Spring");
        }
        else if ((month=="June")||(month=="July")|| (month=="August"))
        {
            System.Console.WriteLine("Summer");
        }
        else if ((month=="September")||(month=="October")|| (month=="November"))
        {
            System.Console.WriteLine("rainfall");
        }
    }
}
