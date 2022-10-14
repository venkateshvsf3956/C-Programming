using System;
namespace MergeSort;
class Program 
{
    public static void Main(string[] args)
    {
        //Giving input to unsorted array
        int []array={18,19,1,5,7,3,20};
        int right=array.Length;
        int left=0;

        //show unsorted array
        System.Console.WriteLine("Unsorted array:");
        for (int i=0;i<right;i++)
        {
            System.Console.Write("\t"+array[i]);
        }
        SortArray(array,left,right-1);
        System.Console.WriteLine("Sorted array:");
        for (int i=0;i<array.Length;i++)
        {
            System.Console.Write("\t"+array[i]);
        }
    
    //sorting the array
    void SortArray(int[]array,int left,int right)
    {
        if (left<right)
        {
            int middle=left+(right-left)/2;
            SortArray(array,left,middle);
            SortArray(array,middle+1,right);
            Merge(array,left,middle,right);

        }
    }
    //merge 
    void Merge(int[]array,int left,int middle,int right)
    {
        int leftArrayLength=middle-left+1;
        int rightArrayLength=right-middle;
        int []leftTempArray=new int [leftArrayLength];
        int []rightTempArray=new int [rightArrayLength];

        int i;
        int j;


        for (i=0;i<leftArrayLength;++i)
        {
            leftTempArray[i]=array[left+i];

        }
        for (j=0;j<rightArrayLength ;++j)
        {
            rightTempArray[j]=array[middle+1+j];
        }
        i=0;
        j=0;
        int k=left;
        while(( i<leftArrayLength)&&(j<rightArrayLength))
        {
            if(leftTempArray[i]<=rightTempArray[j])
            {
                array[k++]=leftTempArray[i++];


            }
            else{
                array[k++]=rightTempArray[j++];
            }
        }
        while(i<leftArrayLength)
        {
            array[k++]=leftTempArray[i++];

        }
        while(j<rightArrayLength)
        {
            array[k++]=rightTempArray[j++];
        }


    }
    }
}