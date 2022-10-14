using System;
namespace Integer;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number to be search in an array:");
        int input=int.Parse(Console.ReadLine());
        int []arr={1,3,4,2,34,56,54,43,32};
        Array.Sort(arr);
        int end=arr.Length;
        int begining=0;
        int mid=0;
        int flag=0;
        for(int i=0;i<=arr.Length-1;i++)
        {
            
            if (input==arr[mid])
            {
                flag=1;
               
                

            }
            else{
                if (input<arr[mid])
                {
                    end=mid-1;
                    mid=(begining+end)/2;
                }
                else{
                    begining=mid+1;
                    mid=(begining+end)/2;
                }
            }

        }
        if (flag==1)
        {
            System.Console.WriteLine("Its present in the array");
             System.Console.WriteLine("Index is:"+mid);
        }
        else{
            System.Console.WriteLine("Its not present in the array");
        }

    }
}