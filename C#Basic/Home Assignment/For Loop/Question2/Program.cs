using System;
namespace Question2;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number:");
        int i;
        int sum=0;
        for (i=1;i<=10;i++)
        {
            
            int input=int.Parse(Console.ReadLine());
            sum=sum+input;
            
        }
        System.Console.WriteLine($"Sum:{sum}");
        double average=(double)sum/10;
        System.Console.WriteLine($"Average:{average}");
    }
}