using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int i=1;
        System.Console.WriteLine("Even number");
        while(i<=100)
        {
            if (i%2==0)
            {
                
                System.Console.WriteLine(i);
            }
            i++;
        }
        System.Console.WriteLine("odd number");
        int j=1;
        while(j<=100)
        {
            if (j%2==1)
            {
                
                System.Console.WriteLine(j);
            }
            j++;

        }
        System.Console.WriteLine("Prime Number");
        int k=0;
        while (k<=100)
        {
            
            int count=1;
            int flag=1;
            while(count<=k)
            {
                if (k%count==0)
                {
                    flag=0;
                }
                count++;
                if (flag==0)
                {
                    System.Console.WriteLine(k);
                }
                k++;
            
            }

        }
    }
}
