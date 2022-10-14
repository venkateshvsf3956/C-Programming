using System;
using System.Collections.Generic;
namespace FilterDelegates;
class Program 
{
    public static void Main(string[] args)
    {
        Person person1=new Person(){Name="John",Age=41};
        Person person2=new Person(){Name="Jacki",Age=69};
        Person person3=new Person(){Name="Jake",Age=12};
        Person person4=new Person(){Name="Dora",Age=10};
        Person person5=new Person(){Name="Ravi",Age=30};
        Person person6=new Person(){Name="Baskar",Age=50};

        List<Person> people=new List<Person>(){person1,person2,person3,person4,person5,person6};


        DisplayPeopele("Children:",people,IsChild);
        DisplayPeopele("Adults:",people,IsAdult);
        DisplayPeopele("Seniors:",people,IsSenior);
        DisplayPeopele("Voters:",people,IsVoter);
    
    }
    public static void DisplayPeopele(string title,List<Person> people,FilterDelegate filter)
    
    {
        System.Console.WriteLine("\n---People in "+title+" list are:----\n");
        foreach(Person p in people)
        {
            if(filter(p))
            {
                System.Console.WriteLine($"{p.Name}  is {p.Age} years old");
            }
        }


    }
    public static bool IsChild(Person p)
    {
        return p.Age<15;

    }
    public static bool IsVoter(Person p)
    {
        return p.Age>=18;
    }
    public static bool IsAdult(Person p)
    {
        if(p.Age>=18 && p.Age<50)
        {
            return true;
        }
        else {
            return false;
        }
    }
    public static bool IsSenior(Person p)
    {
        return p.Age>=50;
    }
}