using System;
namespace Question5;
class Program 
{
public static void Main(string[] args)
{
    System.Console.WriteLine("Enter a string :");
    string str=Console.ReadLine();
    string sum="";
    for (int i=str.Length-1;i>=0;i--)
    {
        sum=sum+i;
        
    }
    if (str==sum)
    {
        System.Console.WriteLine("its a palindrome");
    }
    else
    {
        System.Console.WriteLine("Its not a palindrome");
    }
}
}