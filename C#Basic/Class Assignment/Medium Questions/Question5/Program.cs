using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        for (int i=1;i<=2000;i++)
        {
            if ((i%4==0)||(i%400==0)&&(i%100!=0))
            {
                System.Console.WriteLine(i);
            }
        }
    }
}