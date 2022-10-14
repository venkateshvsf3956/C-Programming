using System;
namespace Question4;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input number of fabonnaci series:");
        int input=int.Parse(Console.ReadLine());
        //System.Console.WriteLine("Fibonnaci series;"+fab());
            int i=1;
            int j=1;
            int k;
            System.Console.WriteLine(i);
            while(i<input)
            {
            
                k=i+j;
                j=i;
                i=k;
                System.Console.WriteLine(i);
               // return i;


            }
        
        
    }
}
