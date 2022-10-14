using System;
namespace OperatorOverLoading;
class Program 
{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,2.2,3.2);
        Box box2=new Box(2.3,3.2,0.9);
        Box box3;
        Double volume=0.0;
        volume=box1.CalculateArea();
        System.Console.WriteLine("Volume of Box1: "+volume);
        volume=box2.CalculateArea();
        System.Console.WriteLine("Volume of Box2: "+volume);
        

        //Add two objects
        box3=box1+box2;
        volume=box3.CalculateArea();
        System.Console.WriteLine("Volume of Box3: "+volume);
        
    }

}