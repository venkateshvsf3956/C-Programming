using System;
namespace Question1;
class Program 
{
    public static void Main(string[] args)
    {
        int [] array=new int [10];
        int i;
        System.Console.WriteLine("Give 10 element in an array");
        for (i=0;i<10;i++)
        {
            System.Console.WriteLine("element-{0}",i);
            array[i]=Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine($"Elements in an array are:");
        for (i=0;i<10;i++)
        {
            System.Console.WriteLine(array[i]);
            
        }
    }
}
