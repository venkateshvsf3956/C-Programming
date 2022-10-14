using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of array:");
        int input=int.Parse(Console.ReadLine());
        int [] array=new int[input];
        int min=array[0];
        int max=array[0];
        
        System.Console.WriteLine($"Give {input} element in an array");
        for (int i=0;i<input;i++)
        {
            System.Console.WriteLine("element-{0}",i+1);
            array[i]=Convert.ToInt32(Console.ReadLine());
            
        }
        for (int i=0;i<input;i++)
        {
            if (min>array[i])
            {
                min=array[i];
            }
           if (max<array[i])
            {
                max=array[i];
            }
        }
        System.Console.WriteLine($"Maximum Element={max}");
        System.Console.WriteLine($"Mininum Element={min}");
    }
}