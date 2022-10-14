using System;
namespace Question9;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the rows and column for the first matrix:");
        int row1=int.Parse(Console.ReadLine());
        int col1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the rows and columns for the second matrix:");
        int row2=int.Parse(Console.ReadLine());
        int col2=int.Parse(Console.ReadLine());
        int [,] array1=new int[100,100];
        int [,] array2=new int[100,100];
        int [,] array3=new int[100,100];
        System.Console.WriteLine("Enter the first element array:");
        for (int i=0;i<row1;i++)
        {
            for (int j=0;j<col1;j++)
            {
                System.Console.WriteLine($"element-{i} {j}");
                array1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Enter the second element array:");
        for (int i=0;i<row2;i++)
        {
            for (int j=0;j<col2;j++)
            {
                System.Console.WriteLine($"element-{i} {j}");
                array2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("The first matrix are:");
        for (int i=0;i<row1;i++)
        {
            System.Console.WriteLine();
            for (int j=0;j<col1;j++)
            {
                Console.Write($"{array1[i,j]}\t");
            }
        }
        System.Console.WriteLine("\nThe second matrix are:\n");
        for (int i=0;i<row2;i++)
        {
            System.Console.WriteLine();
            for (int j=0;j<col2;j++)
            {
                Console.Write($"{array2[i,j]}\t");
            }
        }
        System.Console.WriteLine("\nMultipliction of the matrix\n");
        for (int i=0;i<row1;i++)
        {
            for (int j=0;j<col2;j++)
            {
                array3[i,j]=array1[i,j]*array2[i,j];
            }
        }
        for (int i=0;i<row1;i++)
        {
            for (int j=0;j<col2;j++)
            {
                Console.Write($"{array3[i,j]}\t");
            }
        System.Console.WriteLine();
        }

    }
}
