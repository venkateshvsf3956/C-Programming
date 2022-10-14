using System;
namespace Character;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Character to be search in an array:");
        char input=Char.Parse(Console.ReadLine().ToLower());
        char []arr={'a','c','b','d','e','f','g'};
        Array.Sort(arr);
        int end=arr.Length;
        int begining=0;
        int mid=0;
        int flag=0;
        for(int i=0;i<arr.Length-1;i++)
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
