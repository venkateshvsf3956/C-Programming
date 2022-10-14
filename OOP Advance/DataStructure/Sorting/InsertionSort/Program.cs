using System;
namespace InsertionSort;
class Program 
{
    public static void Main(string[] args)
    {
        int []arr={18,19,1,5,7,3,20};
        int temp=0;
        int j,input;
        for (int i=1;i<=arr.Length-1;i++)
        {
            input=arr[i];
            j=i-1;
            while((j>=0)&&(input<arr[j]))
            {
                temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
                j--;

            }


        }
        System.Console.Write("Sorted array:");
        for (int i=0;i<arr.Length;i++)
        {
            System.Console.Write("\t"+arr[i]);
            
        }
    }
}