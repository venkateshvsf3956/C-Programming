using System;
namespace ListsDs;
class Program 
{
    public static void Main(string[] args)
    {
        ArrayList<object> data=new ArrayList<object>();
        data.AddData(1);
        data.AddData(2);
        data.AddData(3);
        data.AddData(4);
        data.AddData(5);
        System.Console.WriteLine("\n-----Insert----\n");
       // data.Insert(1,2);
        System.Console.WriteLine("\n----RemoveAt-----\n");
       // data.RemoveAt(0);
       System.Console.WriteLine("\n-----Remove----\n");
       data.Remove(2);


    }
}