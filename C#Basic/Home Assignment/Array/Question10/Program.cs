using System;
namespace Question10;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the rows and column for the first matrix:");
        int row1=int.Parse(Console.ReadLine());
        int col1=int.Parse(Console.ReadLine());
        int [,] array1=new int[100,100];
        int [,] array2=new int[100,100];
        System.Console.WriteLine("Enter the first element array:");
        for (int i=0;i<row1;i++)
        {
            for (int j=0;j<col1;j++)
            {
                System.Console.WriteLine($"element-{i} {j}");
                array1[i,j]=int.Parse(Console.ReadLine());
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
        for (int i=0;i<row1;i++)
        {
            for (int j=0;j<col1;j++)
            {
                array2[j,i]=array1[i,j];

            }
        }
        System.Console.WriteLine("\nThe Transpose are:");
        for (int i=0;i<col1;i++)
        {
            System.Console.WriteLine();
            for (int j=0;j<row1;j++)
            {
                System.Console.Write($"{array2[i,j]}\t");
            }
            System.Console.WriteLine();
        }
    }
}
