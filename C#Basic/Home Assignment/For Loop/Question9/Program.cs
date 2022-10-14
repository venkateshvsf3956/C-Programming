using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number:");
        int input=int.Parse(Console.ReadLine());
        int sum=0;
        int temp;

        for (temp=input;input!=0;input=input/10)
        {
            int r=input%10;
            sum =sum+(r*r*r);

        }
        if (sum==temp)
        {
            System.Console.WriteLine("Its Amstrong number");

        }
        else{
            System.Console.WriteLine("Its not a Amstrong number");
        }

    }
}