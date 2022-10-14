using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        string str=Console.ReadLine();
        string sum="";
        for (int i=str.Length-1;i>=0;i--)
        {
            sum=sum+str[i];
        }
        if (str==sum)
        {
            System.Console.WriteLine("Its is a palindrome");
        }
        else
        {
            System.Console.WriteLine("Its not a palindrome");
        }
        
    }
}