using System;
namespace Question6;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter temperature:");
        int temp=Convert.ToInt32(Console.ReadLine());

        if (temp<0)
        {
            System.Console.WriteLine("Freezing weather");
        }
        if ((temp>0)&&(temp<10))
        {
            System.Console.WriteLine("very cold weather");
        }
        else if ((temp>=10)&&(temp<20))
        {
            System.Console.WriteLine("cold weather");
        }
        else if ((temp>=20)&&(temp<30))
        {
            System.Console.WriteLine("Normal in temperature");
        }
        else if ((temp>=30)&&(temp<40))
        {
            System.Console.WriteLine("Its hot");
        }
        else 
        {
            System.Console.WriteLine("Its very hot");
        }
    }
}
