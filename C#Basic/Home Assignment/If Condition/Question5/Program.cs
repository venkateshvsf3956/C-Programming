using System;
namespace Question5;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the physics mark: ");
        int phy=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the chemistry mark: ");
        int che=Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the mathematics mark: ");
        int maths=Convert.ToInt32(Console.ReadLine());

        int sum =phy+che+maths;
        double div=(double)sum/300;
        double percent=div*100;
        if (percent>=75)
        {
            System.Console.WriteLine("The Candidate is eligible for admission.");
        }
        else
        {
            System.Console.WriteLine("The Candidate is not eligible for admission.");
        }
        


    }
}
