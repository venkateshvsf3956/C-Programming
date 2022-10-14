using System;
namespace Question2;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms to display:");
        int input=Convert.ToInt32(Console.ReadLine());
        int a=1;
        int b=1;
        int c=0;
        System.Console.WriteLine(a);
        while(a<input)
        {
            System.Console.WriteLine(a);
            c=a+b;
            b=a;
            a=c;
        }
    }
}