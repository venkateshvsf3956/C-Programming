﻿using System;
namespace Question2;
class Program 
{
    
    public static void Main(string[] args)
    {
        int sum=0;
        for (int i=1;i<100;i++)
        {
            if (i%2!=0)
            {
               sum=sum+(i*i);

            }

        }
        System.Console.WriteLine("Sum of odd Numbers:"+sum);
    }
}