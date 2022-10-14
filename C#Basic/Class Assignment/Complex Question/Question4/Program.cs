using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a string:");
        string str=Console.ReadLine();
        string sum="";
        for (int i=0;i<=str.Length-1;i++)
        {
            if (!sum.Contains (str[i]))
            {
                sum=sum+str[i];
            }
           

        }
        System.Console.WriteLine(sum);
    }
}