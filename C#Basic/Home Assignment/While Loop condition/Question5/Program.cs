using System;
namespace Question;
class Program 
{
    public static void Main(string[] args)
    {
        int number,sum=0,digit;
        System.Console.WriteLine("Enter a number");
        number=int.Parse(Console.ReadLine());
        while(number!=0)
        {
            digit=number%10;
            sum=sum+digit;
            number=number/10;

        }
        System.Console.WriteLine($"Sum of digit is {sum}");
    }
}