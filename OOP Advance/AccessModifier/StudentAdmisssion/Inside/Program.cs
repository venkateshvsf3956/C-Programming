﻿using System;
namespace Inside;
class Program 
{
    public static void Main(string[] args)
    {
        First one=new First();
        System.Console.WriteLine(one.PublicNumber);

        System.Console.WriteLine(one.PrivateOutput);
        System.Console.WriteLine(one.InternalNumber);
        //System.Console.WriteLine(one.ProtectedNumber);
        Second second=new Second();
        System.Console.WriteLine(second.ProtectedOutput);
        System.Console.WriteLine(second.ProtectedInternalOutput);

    }
}