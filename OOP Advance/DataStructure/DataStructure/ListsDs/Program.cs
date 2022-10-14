using System;
namespace ListsDs;
class Program 
{
    public static void Main(string[] args)
    {
        Lists<int> data=new Lists<int>();
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
      foreach(var datas in data)
       {
        System.Console.WriteLine("\t"+datas);

       }
       for (int i=0;i<data.Count;i++)
       {
        System.Console.WriteLine(data[i]);
       }

    }
}