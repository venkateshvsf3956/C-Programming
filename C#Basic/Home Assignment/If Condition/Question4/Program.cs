using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the First number:");
        int first =Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the Second number:");
        int second =Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the third number:");
        int third =Convert.ToInt32(Console.ReadLine());
        if ((first>second)&&(first>third))
        {
            System.Console.WriteLine("The 1st Number is the greatest among three");
        
        }
        if((second>third)&&(second>first))
        {
            System.Console.WriteLine("The 2nd Number is the greatest among three");
        }
        else
        {
            System.Console.WriteLine("The 3rd Number is the greatest among three");
        }

    }
}
