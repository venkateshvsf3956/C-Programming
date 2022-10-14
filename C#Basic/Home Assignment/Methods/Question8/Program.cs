using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the 3 marks:");
        System.Console.WriteLine("Mark1:");
        int num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Mark1:");
        int num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Mark1:");
        int num3=int.Parse(Console.ReadLine());
        int p=0;
        System.Console.WriteLine("Percentage"+Percent());
        int Percent( )
        {
            if ((num1>=35)&&(num2>35)&&(num3>=35))
            {
                int sum=num1+num2+num3;
                p=sum/3;
                
            }
            else 
            {
                System.Console.WriteLine("please enter pass mark.");
            }
            return p;
            
            
        }



    }
}