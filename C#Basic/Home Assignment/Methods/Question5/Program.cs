using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
      System.Console.WriteLine("Enter a number:");
        int input=int.Parse(Console.ReadLine());
        int sum=0;
        System.Console.WriteLine(Prime());
        int  Prime()
        {

        
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
        return input;

        }

  
    }
}