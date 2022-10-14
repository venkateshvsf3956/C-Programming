using System;
namespace Question3;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of array:");
        int input=int.Parse(Console.ReadLine());

        int [] array=new int[input];
        int i;
        int sum =0;
        System.Console.WriteLine($"Give {input} element in an array");
        for (i=0;i<input;i++)
        {
            System.Console.WriteLine("element-{0}",i);
            array[i]=Convert.ToInt32(Console.ReadLine());
            sum=sum+array[i];
        }
        System.Console.WriteLine($"Sum of the array:{sum}");
    }
}
