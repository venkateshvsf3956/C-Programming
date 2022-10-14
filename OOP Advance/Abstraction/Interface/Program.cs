using System;
namespace Interface;
class Program 
{
    public static void Main(string[] args)
    {
        Draw draw=new Draw();
        /*System.Console.WriteLine("Enter the length");
        draw.Length=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Breath");
        draw.Breath=int.Parse(Console.ReadLine());*/
        draw.GetData(2,3);
        draw.CalculateArea();
        draw.show();

    }
}