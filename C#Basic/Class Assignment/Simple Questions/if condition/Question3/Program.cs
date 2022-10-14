using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the speed:");
        int input=Convert.ToInt32(Console.ReadLine());
        if (input<=10)
        {
            System.Console.WriteLine("Slow");
        }
        else if ((input>10)&&(input<=50))
        {
            System.Console.WriteLine("Average");
        }
        else if ((input>50)&&(input<=150))
        {
            System.Console.WriteLine("fast");
        }
        else if ((input>150)&&(input<=1000))
        {
            System.Console.WriteLine("Ultra Fast");
        }
        else if (input>1000)
        {
            System.Console.WriteLine("Extermly fast");
        }
        
    } 
}