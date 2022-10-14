using System;
namespace SealedMethod;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\n------Base class-------");
        Animal sound=new Animal();
        sound.MakeSound();
        System.Console.WriteLine("\n---------Derived class ----------\n");
        Dog sound1=new Dog();
        sound1.MakeSound();
    }
}