using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        string rev="";
        string str="";
        System.Console.WriteLine("Enter a string:");
        str =Console.ReadLine();
        System.Console.WriteLine(Reverese());

        string Reverese()
        {
        for (int i=str.Length-1;i>=0;i--)
        {
             rev= rev+str[i];
        }
        if (rev==str)
        {
            System.Console.WriteLine("Its a plaindrome");
        }
        else
        {
            System.Console.WriteLine("Its not a palindrome.");
        }
        return rev;
        }
    }
}
