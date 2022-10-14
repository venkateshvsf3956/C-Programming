using System;
namespace SelectionSort;
class Program 
{
    public static void Main(string[] args)
    {
        int []arr={18,19,1,5,7,3,20};
        int temp,minValue,minIndex;
        for (int i=0;i<arr.Length;i++)
        {
            minValue=arr[i];
            minIndex=i;
            for (int j=i;j<arr.Length;j++)
            {
                if (arr[j]<minValue)
                {
                    minValue=arr[j];
                    minIndex=j;
                }
            }
            if (minValue<arr[i])
            {
                temp=arr[i];
                arr[i]=arr[minIndex];
                arr[minIndex]=temp;
            }

        }
        System.Console.Write("Sorted array:");
        for (int i=0;i<arr.Length;i++)
        {
            System.Console.Write("\t"+arr[i]);
            
        }
    }
}