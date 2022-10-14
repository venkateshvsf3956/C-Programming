using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input number of terms:");
        int input=int.Parse(Console.ReadLine());
        int sum=0;
        for (int i=1;i<=input+input;i+=2)
        {
            System.Console.WriteLine(i);
            sum=sum+i;
        }
        System.Console.WriteLine($"The sum of odd natural number upto {input}: {sum}");
    }
}
