using System;
namespace QuickSort;
class Program 
{
    public static void Main(string[] args)
    {
        //input array
        int [] array=new int[]{2,5,10,4,3,8,7};

        //Unsorted array
        System.Console.WriteLine("\n-----Unsorted array-----\n");
        foreach(int unsort in array)
        {
            System.Console.Write(" "+unsort);
        }
        //call the Quick sort method
        QuickSort(array,0,array.Length-1);

        //Sorted array
        System.Console.WriteLine("\n----Sorted array-----\n");
        foreach(int sort in array)
        {
            System.Console.Write(" "+sort);

        }





        int Partition(int[] array,int left ,int right)
        {
            int temp;
            int pivot=array[left];
            while(true)
            {
                while(array[left]<pivot)
                {
                    left++;
                }
                while(array[right]>pivot)
                {
                    right--;
                }
                if (left<right)
                {
                    if (array[left]==array[right])
                    {
                        return right;
                    }

                    temp=array[left];
                    array[left]=array[right];
                    array[right]=temp;
                }
                else {
                    return right;
                }
            }

        }


        void QuickSort(int []array,int left,int right)
        {
            if (left<right)
            {
                int pivot =Partition(array,left,right);

                if(pivot >1)
                {
                    QuickSort(array,left,pivot-1);
                }
                if(pivot+1<right)
                {
                    QuickSort(array,pivot+1,right);
                }

            }
            

        }


        
    }
}