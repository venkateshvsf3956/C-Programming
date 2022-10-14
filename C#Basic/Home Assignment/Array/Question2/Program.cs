using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of array:");
        int input=int.Parse(Console.ReadLine());

        int [] array=new int[input];
        int i;
        System.Console.WriteLine($"Give {input} element in an array");
        for (i=0;i<input;i++)
        {
            System.Console.WriteLine("element-{0}",i+1);
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine($"Reverse Elements in an array are:");
        Array.Reverse(array);
        foreach( int j in array)
        {
            System.Console.WriteLine(j);
        }
            
        
    }
}