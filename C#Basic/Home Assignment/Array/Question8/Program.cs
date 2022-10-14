using System;
namespace Question8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the array:");
        int input=int.Parse(Console.ReadLine());
        int [,] array1=new int[100,100];
        int [,] array2=new int[100,100];
        int [,] array3=new int [100,100];
        System.Console.WriteLine("Give the array element to first matrix:");
        for (int i=0;i<input;i++)
        {
            for (int j=0;j<input;j++)
            {
                Console.WriteLine($"elements-[{i}] [{j}]");
                array1[i,j]=int.Parse(Console.ReadLine());

                
            }
        }
        System.Console.WriteLine("Give the array element to second matrix:");
        for (int i=0;i<input;i++)
        {
            for (int j=0;j<input;j++)
            {
                Console.WriteLine($"elements-[{i}] [{j}]");
                array2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("The first matrix are:");
        for (int i=0;i<input;i++)
        {
            System.Console.WriteLine();
            for (int j=0;j<input;j++)
            {
                Console.Write($"{array1[i,j]}\t");
            }
        }
        System.Console.WriteLine("\nThe second matrix are:\n");
        for (int i=0;i<input;i++)
        {
            System.Console.WriteLine();
            for (int j=0;j<input;j++)
            {
                Console.Write($"{array2[i,j]}\t");
            }
        }
        System.Console.WriteLine("\nSum of the matrix\n");
        for (int i=0;i<input;i++)
        {
            for (int j=0;j<input;j++)
            {
                array3[i,j]=array1[i,j]+array2[i,j];
            }
        }
        for (int i=0;i<input;i++)
        {
            for (int j=0;j<input;j++)
            {
                Console.Write($"{array3[i,j]}\t");
            }
        System.Console.WriteLine();
        }



    }
}