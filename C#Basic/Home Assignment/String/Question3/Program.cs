using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter  the String:");
        string str=Console.ReadLine();
        int l=0;
        l=str.Length-1;
        while(l>=0)
        {
            System.Console.Write(str[l]);
            l--;
        }
    }
}