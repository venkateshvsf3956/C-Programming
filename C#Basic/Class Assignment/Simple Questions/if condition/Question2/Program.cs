using System;
namespace Question2;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a integer");
        int input=Convert.ToInt32(Console.ReadLine());
        if ((input<100)&&(input>0))
        {
            System.Console.WriteLine("Less than 100");
        }
        else if  ((input<=200)&&(input>=100))
        {
            System.Console.WriteLine("Between 100 and 200");
        }
        else if (input>200)
        {
            System.Console.WriteLine("Greater than 200");
        }
        
    }
}