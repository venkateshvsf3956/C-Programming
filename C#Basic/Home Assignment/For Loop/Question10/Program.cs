using System;
namespace Question10;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a numer:");
        int input=int.Parse(Console.ReadLine());
        int sum=0;
        for (int i=1;i<=input;i++)
        {
            if (input%i==0)
            {
                sum++;
            }

        }
        if (sum==2)
        {
            System.Console.WriteLine("Its a prime number");
        }
        else{
            System.Console.WriteLine("Its not a prime number");
        }

    }
}