using System;
namespace DictionaryDs;
class Program 
{
    public static void Main(string[] args)
    {
        KeyValue<int,string> obj=new KeyValue<int,string>();
        obj.Add(1,"Venkat");
        obj.Add(2,"Jose");
        obj.Add(3,"Vikram");
        System.Console.WriteLine(obj.ContainsKey(3)); 
        System.Console.WriteLine(obj.ContainsValue("Vikram"));
        System.Console.WriteLine(obj.Remove(2));
        
        foreach(KeyValue<int,string> i in obj)
        {
            System.Console.WriteLine(i.Key+" "+i.Value);
        }

    }
}
