using System;
namespace Question7;
class Program 
{
    public static void Main(string[] args)
    {
        int [,] array=new int [3,3];
        int i,j;
        System.Console.WriteLine("Enter the array:");
        for (i=0;i<3;i++)
        {
            for (j=0;j<3;j++)
            {
                System.Console.WriteLine($"element-{i} {j}");
                array[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("The matrix are:");
        for (i=0;i<3;i++)
        {
        
            for (j=0;j<3;j++)
            {
                System.Console.Write(array[i,j]);
            }
        System.Console.WriteLine();
        }
    }
}