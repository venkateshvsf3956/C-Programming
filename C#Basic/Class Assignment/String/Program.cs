﻿using System;
namespace String;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a string ");
        string str1=Console.ReadLine();
        System.Console.WriteLine("Enter a substring");
        string str2=Console.ReadLine();
        

        string[] subs = str1.Split(str2);
        System.Console.WriteLine(subs.Length-1);
       
    }
}